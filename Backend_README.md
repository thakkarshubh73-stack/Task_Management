Task Management API – ASP.NET Core Web API

A simple Task Management REST API built with ASP.NET Core Web API, Entity Framework Core, and Repository Pattern.
This API allows you to manage tasks with full CRUD operations.

Features :-

Create, Read, Update, and Delete tasks

Repository Pattern for clean separation

DTO for incoming data

EF Core for database operations

Auto-generated timestamps (CreatedAt, UpdatedAt)

Tracks MachineName for audit

Technology Used:-

.NET 7 / .NET 8

ASP.NET Core Web API

Entity Framework Core

SQL Server

Moq (Mocking dependencies)

### Project Structure

TaskManagement_BE/
│
├── Controllers/
│   └── TaskManagementController.cs
│
├── Repository/
│   ├── ITaskRepository.cs
│   └── TaskRepository.cs
│
├── DTOs/
│   └── TaskDto.cs
│
├── Model/
│   └── TaskItem.cs
│
├── AppData/
│   └── TaskManagementEntity.cs
│
└── Program.cs

🧪 API Endpoints
GET – Get all tasks
GET /api/TaskManagement

POST – Create new task
POST /api/TaskManagement

PUT – Update task
PUT /api/TaskManagement/{id}

DELETE – Delete task
DELETE /api/TaskManagement/{id}

⚙ How to Run the Project
1. Restore dependencies
dotnet restore

2. Apply EF Core migrations
dotnet ef database update

3. Run the project
dotnet run

4. Open Swagger
https://localhost:{port}/swagger

📘 Task DTO Example
{
  "title": "Test Task",
  "description": "Details",
  "dueDate": "2025-01-01",
  "status": "Pending"
}
