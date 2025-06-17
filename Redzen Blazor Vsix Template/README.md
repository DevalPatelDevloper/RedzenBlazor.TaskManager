
# ✅ RedzenBlazor.TaskManager - Proof of Concept

This repository contains a **fully functional Proof of Concept (PoC)** for a task management system built using the **Redzen Blazor VSIX Template**. The PoC demonstrates how to structure, develop, and run a modular Blazor Server application using Redzen's template.

## 📋 Prerequisites

### Tools Required
- **Visual Studio 2022 or later** (Blazor development workload installed)
- **.NET 7.0 SDK** or **.NET 8.0 SDK** (preferably LTS version)
- **Node.js** (optional for frontend packages)
- **Git** (for version control)

### Services and Configurations
- Local SQL Server or SQLite instance (if storing tasks persistently)
- HTTPS Development Certificate (auto-trusted using `dotnet dev-certs https --trust`)

## 📌 What the PoC Is About

The `RedzenBlazor.TaskManager` PoC is a minimal project demonstrating:
- Task creation, update, and deletion
- Listing tasks in a dynamic, paginated table
- Modular service layer for business logic
- Reusable Razor components using Redzen's base structure

## 🧭 When and Why to Use This Template

### ✅ Use this template when:
- You need a **quick start** with consistent architecture
- You're building internal tools or dashboards
- You prefer **server-side Blazor** for performance or simplicity

### ❌ Avoid this template when:
- You require Blazor WebAssembly
- Your use case mandates older .NET frameworks (pre-7.0)

## 🛠 How to Implement the Solution

### Step 1: Install Redzen Blazor Template
- Install the `Redzen.Blazor.Template.vsix`
- Restart Visual Studio

### Step 2: Create the Project
- Create a new project using **Redzen Blazor Server App**
- Name it `RedzenBlazor.TaskManager`
- Select **.NET 7.0** or **8.0** (LTS preferred), disable Docker, no authentication

### Step 3: Build the Task Manager
- Add `TaskService` under `/Services`
- Add `Task` model under `/Models`
- Create CRUD pages in `/Pages/Tasks.razor`

### Step 4: Run and Test
- Press `F5` or `Ctrl+F5`
- Use the left nav bar to access "Tasks" page


### Program.cs
```csharp
builder.Services.AddSingleton<TaskService>();
```

## 💡 Use Cases

### 1. Internal Team Task Tracker
- Assign tasks by priority and due date
- Track status (Pending,InProgress,Completed)

### 2. Bug Reporting System
- Use categories and filters for project bugs

### 3. Personal To-Do App
- Simplified task list with local storage

## 🧯 Troubleshooting Steps

| Problem                         | Solution                                                     |
|----------------------------------|--------------------------------------------------------------|
| Template not appearing          | Ensure VSIX is installed and restart Visual Studio           |
| HTTPS-related browser warning   | Run `dotnet dev-certs https --trust`                         |
| .NET 8.0 not available          | Download from https://dotnet.microsoft.com/en-us/download   |
| Blazor page not routing         | Check `_Imports.razor` and NavMenu links                     |

## 📁 Project Structure

```
/RedzenBlazor.TaskManager
│
├── /Pages              → Task pages
├── /Shared             → Layouts, NavMenu
├── /Services           → TaskService.cs
├── /Models             → TaskItem.cs
├── Program.cs          → Configuration
├── appsettings.json    → App settings
```

## 🧾 Summary

The `RedzenBlazor.TaskManager` PoC is a lightweight yet extensible example of how to use the Redzen Blazor VSIX Template to create enterprise-grade applications quickly and efficiently. It's suitable for dashboards, task boards, and team tracking solutions.
