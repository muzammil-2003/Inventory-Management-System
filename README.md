# Inventory Management System

A Windows desktop inventory management application built with C# WinForms and SQL Server.

The project provides a simple layered architecture for managing core inventory operations such as products, categories, suppliers, customers, billing, and dashboard reporting.

## Features

- User login form
- Dashboard with live date and time
- Total products, categories, suppliers, stock, and inventory value summary
- Low-stock product list
- Recently added products list
- Product management
- Category management
- Supplier management
- Customer management
- Billing / invoice workflow
- Repository-based data access layer
- SQL Server database connectivity

## Tech Stack

- C#
- .NET Framework 4.7.2
- WinForms
- Microsoft.Data.SqlClient
- SQL Server
- Visual Studio

## Project Structure

```text
InventoryManagementSystem
|-- Database
|   `-- DatabaseHelper.cs
|-- Forms
|   |-- LoginForm.cs
|   |-- DashboardForm.cs
|   |-- ProductForm.cs
|   |-- CategoryForm.cs
|   |-- SupplierForm.cs
|   |-- CustomerForm.cs
|   `-- BillingForm.cs
|-- Models
|   |-- User.cs
|   |-- Product.cs
|   |-- Category.cs
|   |-- Supplier.cs
|   |-- Customer.cs
|   |-- Invoice.cs
|   `-- InvoiceItem.cs
|-- Repositories
|   |-- UserRepository.cs
|   |-- DashboardRepository.cs
|   |-- ProductRepository.cs
|   |-- CategoryRepository.cs
|   |-- SupplierRepository.cs
|   |-- CustomerRepository.cs
|   `-- InvoiceRepository.cs
|-- App.config
|-- Program.cs
`-- InventoryManagementSystem.csproj
```

## Requirements

- Visual Studio 2022 or later
- .NET Framework 4.7.2 Developer Pack
- SQL Server or SQL Server Express

## Setup

1. Clone the repository.
2. Open `InventoryManagementSystem.slnx` or `InventoryManagementSystem.csproj` in Visual Studio.
3. Restore NuGet packages.
4. Create a SQL Server database named `InventoryDB`.
5. Update the connection string in [DatabaseHelper.cs](./Database/DatabaseHelper.cs) if your SQL Server instance is different.
6. Build and run the project.

## Database Configuration

The default connection string is defined in [DatabaseHelper.cs](./Database/DatabaseHelper.cs):

```csharp
Server=.\\SQLEXPRESS;Database=InventoryDB;Trusted_Connection=True;TrustServerCertificate=True;
```

If your local SQL Server setup is different, change the server name, authentication mode, and database name to match your environment.

## Notes

- The application currently starts from `DashboardForm` in [Program.cs](./Program.cs).
- The login screen is included in the project and can be used as the entry point if you want to switch startup flow later.
- The database schema scripts are not included in this repository, so the required tables should match the queries used in the repository classes.

## Status

Active development.

## Author

**Muzammil**

GitHub: https://github.com/muzammil-2003