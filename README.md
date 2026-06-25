# Inventory Management System

A desktop-based Inventory Management System built with C# WinForms and SQL Server. This application helps manage inventory-related operations such as suppliers, categories, users, and stock management through an intuitive graphical interface.

## Features

### Current Modules
- User Authentication (Login System)
- Dashboard Overview
- Category Management
- Supplier Management
- User Management
- Database Connectivity with SQL Server
- Repository Pattern for Data Access

### Planned Features
- Product Management
- Inventory Tracking
- Stock In / Stock Out
- Sales Management
- Reports and Analytics
- Role-Based Access Control
- Data Export (Excel/PDF)

---

## Technologies Used

- C#
- .NET Framework WinForms
- SQL Server
- ADO.NET
- Visual Studio

---

## Project Structure

```text
InventoryManagementSystem
│
├── Database
│   └── DatabaseHelper.cs
│
├── Forms
│   ├── LoginForm.cs
│   ├── DashboardForm.cs
│   ├── CategoryForm.cs
│   └── SupplierForm.cs
│
├── Models
│   ├── User.cs
│   ├── Category.cs
│   └── Supplier.cs
│
├── Repositories
│   ├── UserRepository.cs
│   ├── CategoryRepository.cs
│   └── SupplierRepository.cs
│
├── App.config
├── Program.cs
└── packages.config
```

---

## Architecture

The project follows a simple layered structure:

- **Forms** → User Interface
- **Models** → Data Models/Entities
- **Repositories** → Database Operations
- **Database Helper** → Database Connection Management

This separation improves maintainability and makes future expansion easier.

---

## Database Configuration

Update the connection string in `App.config` according to your SQL Server setup.

Example:

```xml
<connectionStrings>
    <add name="InventoryDB"
         connectionString="YOUR_CONNECTION_STRING_HERE" />
</connectionStrings>
```

---

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- SQL Server
- .NET Framework

### Installation

1. Clone the repository:

```bash
git clone https://github.com/your-username/Inventory-Management-System.git
```

2. Open the solution in Visual Studio.

3. Configure the database connection.

4. Build and run the project.

---

## Screenshots

Screenshots will be added as the project progresses.

---

## Future Improvements

- Product Module
- Inventory Reports
- Sales Tracking
- Barcode Integration
- Notification System
- Multi-user Support

---

## Status

🚧 Project Under Development

This project is actively being developed and new features will be added regularly.

---

## Author

**Muzammil**

GitHub: https://github.com/muzammil-2003