# 🏢 Company Management System API

A RESTful API built with C# for managing a company's core operations — including employees, departments, contracts, and projects — through full CRUD functionality.

---

## 📋 Description

The Company Management System API provides a structured backend to handle all internal company data. It supports creating, reading, updating, and deleting records across four main domains: Employees, Departments, Contracts, and Projects.

---

## ✨ Features

- 👷 **Employee Management** — Full CRUD for company employees
- 🏗️ **Department Management** — Manage company departments
- 📝 **Contract Management** — Handle employee and project contracts
- 📁 **Project Management** — Track and manage company projects

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Language | C# |
| Framework | ASP.NET Core Web API |
| Architecture | RESTful API |

---

## 🔌 API Endpoints

### 👷 Employee Controller — `/api/employees`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/employees` | Get all employees |
| POST | `/api/employees` | Create a new employee |
| PUT | `/api/employees/{id}` | Update an existing employee |
| DELETE | `/api/employees/{id}` | Delete an employee |

**Create / Update Request Body:**
```json
{
  "name": "Ahmed Ali",
  "email": "ahmed@company.com",
  "phone": "01012345678",
  "departmentId": 2,
  "position": "Software Developer"
}
```

---

### 🏗️ Department Controller — `/api/departments`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/departments` | Get all departments |
| POST | `/api/departments` | Create a new department |
| PUT | `/api/departments/{id}` | Update an existing department |
| DELETE | `/api/departments/{id}` | Delete a department |

**Create / Update Request Body:**
```json
{
  "name": "Software Development",
  "managerId": 1
}
```

---

### 📝 Contract Controller — `/api/contracts`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/contracts/{id}` | Get a specific contract by ID |
| POST | `/api/contracts` | Create a new contract |
| PUT | `/api/contracts/{id}` | Update an existing contract |
| DELETE | `/api/contracts/{id}` | Delete a contract |

**Create / Update Request Body:**
```json
{
  "employeeId": 3,
  "startDate": "2024-01-01",
  "endDate": "2025-01-01",
  "salary": 15000,
  "type": "Full-Time"
}
```

---

### 📁 Project Controller — `/api/projects`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/projects` | Get all projects |
| POST | `/api/projects` | Create a new project |
| PUT | `/api/projects/{id}` | Update an existing project |
| DELETE | `/api/projects/{id}` | Delete a project |

**Create / Update Request Body:**
```json
{
  "name": "HR System",
  "description": "Internal HR management platform",
  "startDate": "2024-03-01",
  "deadline": "2024-09-01",
  "departmentId": 2
}
```

---

## 📊 Endpoint Summary

| Controller | GET All | POST | PUT | DELETE |
|------------|---------|------|-----|--------|
| Employee | ✅ | ✅ | ✅ | ✅ |
| Department | ✅ | ✅ | ✅ | ✅ |
| Project | ✅ | ✅ | ✅ | ✅ |

| Controller | GET By ID | POST | PUT | DELETE |
|------------|-----------|------|-----|--------|
| Contract | ✅ | ✅ | ✅ | ✅ |

---

## 📂 Project Structure

```
CompanyManagementAPI/
├── Controllers/
│   ├── EmployeeController.cs
│   ├── DepartmentController.cs
│   ├── ContractController.cs
│   └── ProjectController.cs
├── Models/
│   ├── Employee.cs
│   ├── Department.cs
│   ├── Contract.cs
│   └── Project.cs
├── DTOs/
│   ├── EmployeeDto.cs
│   ├── DepartmentDto.cs
│   ├── ContractDto.cs
│   └── ProjectDto.cs
├── Services/
│   └── (business logic here)
├── Program.cs
└── README.md
```

---

## 🚀 Getting Started

### Prerequisites

- .NET SDK 6.0 or higher
- Visual Studio / VS Code
- A configured database connection

### Run the Project

```bash
# Clone the repository
git clone https://github.com/Salah-Aldeen-Ibrahem/company-management-api.git

# Navigate to project directory
cd company-management-api

# Restore dependencies
dotnet restore

# Run the API
dotnet run
```

The API will be available at `https://localhost:5001` or `http://localhost:5000`.

---

## 👨‍💻 Author

**Salah Aldeen Eid Khamis**
- GitHub: [@Salah-Aldeen-Ibrahem](https://github.com/Salah-Aldeen-Ibrahem)
- LinkedIn: [salah-aldeen-518b8131b](https://www.linkedin.com/in/salah-aldeen-518b8131b)

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).
