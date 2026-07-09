# 🏠 Real Estate Management System

![C#](https://img.shields.io/badge/Language-C%23-blue)
![.NET](https://img.shields.io/badge/Framework-.NET%209-purple)
![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-green)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)
![Architecture](https://img.shields.io/badge/Architecture-N--Tier-orange)
![Data Access](https://img.shields.io/badge/Data%20Access-ADO.NET-yellow)
![Git](https://img.shields.io/badge/Version%20Control-Git-orange)

A professional desktop real estate management application built using **C# WinForms**, **.NET 9**, **SQL Server**, and **N-Tier Architecture**.

The application provides a complete solution for managing real estate operations including clients, properties, contracts, payments, and reports through separated Presentation, Data Access, Entity, and Helper layers.

---

# 📑 Table of Contents

* [Features](#-features)
* [Technology Stack](#-technology-stack)
* [Architecture](#-architecture)
* [Database](#-database)
* [Installation](#-installation)
* [Project Structure](#-project-structure)
* [Notes](#-notes)
* [Future Improvements](#-future-improvements)
* [Contact](#-contact)

---

# 🚀 Features

## 🔐 User Authentication

* Secure login system.
* Validate user credentials against the database.
* Authentication handled through:

```csharp
LoginDAL.CheckLogin
```

---

# 👥 Client Management

The system provides complete client management.

## Features

* Display all clients.
* Add new clients.
* Edit existing clients.
* Delete clients.
* Search clients by name or phone.

## Business Rules

* Prevent deleting clients with existing contracts.

## Implemented Operations

```csharp
ClientDAL.GetAllClients
ClientDAL.SearchClients
ClientDAL.HasContracts
```

---

# 🏠 Property Management

Manage real estate properties.

## Features

* Display all properties.
* Add new properties.
* Update properties.
* Delete properties.
* Change property status.

## Property Status

```text
Available
Rented
Sold
```

## Implemented Operations

```csharp
PropertyDAL.GetAllProperties
PropertyDAL.UpdateStatus
PropertyDAL.GetAllForSelection
```

---

# 📄 Contract Management

Complete contract lifecycle management.

## Features

* Display contracts.
* Create contracts.
* Update contracts.
* Delete contracts.
* View contracts by client.
* Search contracts by client name.

## Additional Features

* Automatically update property status when creating contracts.
* Export contracts to CSV.
* Print contracts.

## Implemented Operations

```csharp
ContractDAL.GetAllContracts
ContractDAL.GetContractsByClient
ContractDAL.AddNewContract
ContractDAL.Update
ContractDAL.Delete
ContractDAL.SearchContractsByClientName
```

---

# 💰 Payment Management

Manage contract payments.

## Features

* Display payments by contract.
* Add payments.
* Delete payments.
* Calculate payment summaries.

## Payment Calculations

```text
Paid Amount
Remaining Amount
```

## Implemented Operations

```csharp
PaymentDAL.GetPaymentsByContract
PaymentDAL.AddNewPayment
PaymentDAL.DeletePayment
PaymentDAL.GetContractSummary
```

## Business Rules

* Prevent deleting contracts that contain payments.

---

# 📊 Reporting

The system provides reporting capabilities.

## Features

* Retrieve contract reports.
* Display payment summaries.
* Filter reports by date range.

## Implemented Operations

```csharp
ReportsDAL.GetContractsReport
ReportsDAL.GetAllContracts
```

---

# 🖨 Additional UI Features

The application includes:

* DataGridView row numbering.
* Input validation.
* Context menu navigation.
* DataGridView printing.
* CSV export functionality.

---

# 🛠 Technology Stack

| Category        | Technology               |
| --------------- | ------------------------ |
| Language        | C#                       |
| Framework       | .NET 9                   |
| UI              | Windows Forms            |
| Database        | Microsoft SQL Server     |
| Data Access     | ADO.NET                  |
| SQL Provider    | Microsoft.Data.SqlClient |
| Architecture    | N-Tier Architecture      |
| Export          | CSV                      |
| Printing        | System.Drawing.Printing  |
| Version Control | Git & GitHub             |

---

# 🏛 Architecture

The application follows a layered **N-Tier Architecture**.

```text
RealEstate.UI
      |
      ↓
RealEstate.DataAccess
      |
      ↓
RealEstate.Entities
      |
      ↓
RealEstate.Helpers
      |
      ↓
SQL Server Database
```

---

## Presentation Layer

Project:

```text
RealEstate.UI
```

Responsibilities:

* Provides Windows Forms interface.
* Handles user interaction.
* Displays application data.

Main Forms:

```text
FrmLogin
FrmMain
FrmClients
FrmProperties
FrmContracts
FrmPayments
FrmReports
FrmSettings
```

---

## Data Access Layer

Project:

```text
RealEstate.DataAccess
```

Responsibilities:

* Communicates with SQL Server.
* Executes SQL commands.
* Performs CRUD operations.

Main Classes:

```text
ClientDAL
PropertyDAL
ContractDAL
PaymentDAL
ReportsDAL
LoginDAL
Database
```

---

## Entity Layer

Project:

```text
RealEstate.Entities
```

Contains DTO classes:

```text
Client
Property
Contract
Payment
```

---

## Helper Layer

Project:

```text
RealEstate.Helpers
```

Contains reusable utilities:

```text
DataGridViewPrinter
```

---

# 🗄 Database

The application uses:

```text
Microsoft SQL Server
```

Database:

```text
RealEstateDB
```

Required tables:

```text
Users
Clients
Properties
Contracts
Payments
```

Database access:

```text
RealEstate.DataAccess
└── Database.cs
```

The repository does not include:

* Database creation scripts.
* Migration files.
* Initial database data.

---

# ⚙ Installation

## Requirements

Install:

* Visual Studio 2022 or newer.
* .NET 9 SDK.
* Microsoft SQL Server.

---

## Setup

1. Open the solution:

```text
RealEstateSolution.sln
```

2. Update the connection string:

```text
RealEstate.DataAccess
└── Database.cs
```

3. Configure:

```csharp
Database.ConnectionString
```

with your SQL Server instance.

4. Ensure the database exists:

```text
RealEstateDB
```

5. Set:

```text
RealEstate.UI
```

as startup project.

6. Build and run the application.

---

# 📂 Project Structure

```text
RealEstateSolution
│
├── RealEstate.UI
│   ├── FrmLogin
│   ├── FrmMain
│   ├── FrmClients
│   ├── FrmProperties
│   ├── FrmContracts
│   ├── FrmPayments
│   └── FrmReports
│
├── RealEstate.DataAccess
│   ├── ClientDAL
│   ├── PropertyDAL
│   ├── ContractDAL
│   ├── PaymentDAL
│   ├── ReportsDAL
│   └── Database
│
├── RealEstate.Entities
│   ├── Client
│   ├── Property
│   ├── Contract
│   └── Payment
│
├── RealEstate.Helpers
│   └── DataGridViewPrinter
│
└── README.md
```

---

# 📝 Notes

* Desktop Windows Forms application.
* Uses direct SQL queries with ADO.NET.
* No Entity Framework is used.
* No automated tests are included.
* Database scripts are not included.
* Logging system is not implemented.
* Authentication depends on database user records.

---

# 🔮 Future Improvements

Possible improvements:

* Add database migration scripts.
* Implement Repository Pattern.
* Add Entity Framework Core support.
* Add centralized exception handling.
* Add logging framework.
* Add automated testing.
* Implement role-based authorization.

---

# 📧 Contact

**Albara Fahed Alharissy**

Software Engineer | C# .NET Developer

LinkedIn:

https://www.linkedin.com/in/albara-csharp-developer/

GitHub:

https://github.com/Albarafahed
