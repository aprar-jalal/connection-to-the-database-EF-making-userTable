# Database Connection with Entity Framework — User Table

A **C# / ASP.NET** project demonstrating how to connect to a database using **Entity Framework (EF)** and scaffold a `User` table using the Code-First approach.

## 🛠️ Tech Stack

- **Language:** C# (100%)
- **ORM:** Entity Framework (EF)
- **Framework:** ASP.NET

## 📁 Project Structure

```
connection-to-the-database-EF-making-userTable/
├── connection to the database EF/    # Main project directory
└── connection to the database EF.sln # Visual Studio solution file
```

## ✨ Features

- Database connection setup using Entity Framework
- Code-First approach to database schema
- `User` table creation via EF migrations
- Demonstrates the EF DbContext pattern

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET SDK
- SQL Server (or LocalDB)
- Entity Framework NuGet package

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/aprar-jalal/connection-to-the-database-EF-making-userTable.git
   ```
2. Open `connection to the database EF.sln` in Visual Studio.
3. Update the connection string in `appsettings.json` or `Web.config` to point to your database.
4. Run EF migrations to create the database:
   ```
   Update-Database
   ```
5. Build and run the project.

## 📄 License

This project is open source and available for educational use.
