# Task Management System

## Project Overview
The **Task Management System** is a simple yet effective Windows Forms (WinForms) application built using **ASP.NET Core** with **Entity Framework Core**. This system is designed for a single user to efficiently manage personal tasks while leveraging **LINQ queries** for data operations.

## Features
### Basic Features
- CRUD operations for tasks (Create, Read, Update, Delete)
- Filter tasks by status (Pending, Completed, etc.)
- Sort tasks by due date

### Intermediate Features
- Search tasks by title/description
- Group tasks by priority
- Show unique task priorities
- Paginate tasks (e.g., 5 per page)

### Advanced Features
- Track overdue tasks & send alerts
- Generate reports for completed vs pending tasks
- Calculate average task completion time
- Custom control implementation
- Advanced reporting (scope TBD)

## Database Schema
### Entities
#### Task Entity
```csharp
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Priority { get; set; } // Low, Medium, High
    public Enum Status { get; set; } // Pending, In Progress, Completed
}
```

#### User Entity
```csharp
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
```

#### Category Entity
```csharp
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

### Relationships
- **User - TaskItem (One-to-Many)**
  - A User can have multiple TaskItems.
  - Each TaskItem belongs to a single User.
- **Category - TaskItem (One-to-Many)**
  - A Category can have multiple TaskItems.
  - Each TaskItem belongs to a single Category.

## Technologies Used
- **C#** (WinForms, ASP.NET Core)
- **Entity Framework Core** (EF Core)
- **SQL Server** (Database Management)
- **LINQ** (Querying Data)

## Installation & Setup
1. **Clone the repository:**
   ```sh
   git clone https://github.com/AbdelzaherAbdelgwad/WinForm_Task_Manager.git
   ```
2. **Navigate to the project directory:**
   ```sh
   cd task-management-system
   ```
3. **Set up the database:**
   - Update the connection string in `appsettings.json`
   - Run migrations:
     ```sh
     dotnet ef database update
     ```
4. **Run the application:**
   ```sh
   dotnet run
   ```



