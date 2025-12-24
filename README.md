# ✅ TaskMaster API

O **TaskMaster API** é um sistema de backend desenvolvido em .NET para gerenciamento de tarefas (To-Do List). O projeto permite criar, organizar e acompanhar o status de tarefas diárias, aplicando regras de negócio para validação de datas e integridade dos dados.

## 🚀 Funcionalidades

* **CRUD Completo:** Criação, Leitura, Atualização e Exclusão de tarefas.
* **Separação de Responsabilidades:** Arquitetura dividida em Controllers, Entities, Models e Enums.
* **Validações Inteligentes:**
    * Impossível definir data de término menor que a de início.
    * Tarefas nascem sempre como "Pendentes".
    * Títulos devem ter tamanho mínimo.
* **Armazenamento em Memória:** Simulação de banco de dados utilizando Listas Estáticas.

## 🛠️ Tecnologias

* C# e .NET 6/7/8
* ASP.NET Core Web API
* Swagger (OpenAPI) para documentação e testes

## 🔌 Endpoints

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| **POST** | `/api/Task` | Cria uma nova tarefa (Status padrão: Pending). |
| **GET** | `/api/Task` | Lista todas as tarefas (suporta filtros). |
| **GET** | `/api/Task/{id}` | Busca uma tarefa específica pelo ID. |
| **PUT** | `/api/Task/{id}` | Atualiza uma tarefa (permite mudar Status). |
| **DELETE** | `/api/Task/{id}` | Remove uma tarefa do sistema. |

## 🧩 Estrutura de Dados (Enums)

### Prioridade (Priority)
* `1` - Low (Baixa)
* `2` - Medium (Média)
* `3` - High (Alta)

### Status
* `1` - Pending (Pendente)
* `2` - InProgress (Em andamento)
* `3` - Completed (Concluída)

---
*Projeto desenvolvido para fins de praticas em C#.*