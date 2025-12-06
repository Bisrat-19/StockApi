# Stock API

A RESTful API built with ASP.NET Core 8.0 for managing stocks and their associated comments. This API provides full CRUD operations for both stocks and comments with a SQLite database backend.

## 🚀 Features

- **Stock Management**: Create, read, update, and delete stock information
- **Comment System**: Add comments to stocks with full CRUD capabilities
- **SQLite Database**: Lightweight, file-based database with Entity Framework Core
- **Swagger Documentation**: Interactive API documentation at `/swagger`
- **Repository Pattern**: Clean architecture with separated data access layer

## 📋 Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQLite (included with .NET)

## 🛠️ Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd StockApi
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

   Or use watch mode for development:
   ```bash
   dotnet watch run
   ```
