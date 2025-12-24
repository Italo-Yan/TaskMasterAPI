using Microsoft.AspNetCore.Mvc;
using TaskMasterAPI.Entity;
using TaskMasterAPI.Model;

namespace TaskMasterAPI.Controllers
{
    [Route("api/Task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private static List<UserTask> _tasks = new List<UserTask>();

        [HttpPost]
        public IActionResult CreateTask([FromBody] CreateUserTask request)
        {
            if (request.Title.Length < 5)
            {
                return BadRequest("Title must be at least 5 characters long.");
            }

            if (request.DueDate <= request.StartDate)
            {
                return BadRequest("Due date must be later than start date.");
            }

            var newTask = new UserTask
            {
                Title = request.Title,
                Description = request.Description,
                StartDate = request.StartDate,
                DueDate = request.DueDate,
                Priority = request.Priority,
            };

            _tasks.Add(newTask);

            return CreatedAtAction(nameof(GetTaskById), new { id = newTask.Id }, newTask);
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(_tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskById(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound("Task not found.");
            }
            return Ok(task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(Guid id, [FromBody] UpdateUserTask request)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask == null)
            {
                return NotFound("Task not found.");
            }
            if (request.Title.Length < 5)
            {
                return BadRequest("Title must be at least 5 characters long.");
            }
            if (request.DueDate <= request.StartDate)
            {
                return BadRequest("Due date must be later than start date.");
            }
            existingTask.Title = request.Title;
            existingTask.Description = request.Description;
            existingTask.StartDate = request.StartDate;
            existingTask.DueDate = request.DueDate;
            existingTask.Priority = request.Priority;
            existingTask.Status = request.Status;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound("Task not found.");
            }
            _tasks.Remove(task);
            return NoContent();
        }
    }
}
