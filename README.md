# 📚 Community Hall & Library Website - Backend

This is the backend for the **Community Hall & Library Website** project.  
It provides API endpoints for:
- 📖 Book borrowing (physical books)
- 🏛 Membership management (optional membership)
- 🗓 Room booking
- 🔑 User authentication with JWT

---

## 🚀 Tech Stack

- **.NET 8 (ASP.NET Core Web API)**
- **Entity Framework Core** for database access
- **SQL Server** (LocalDB for development)
- **JWT Authentication**
- **Swagger/OpenAPI** for API documentation

---

## 📦 Dependencies

| Package | Purpose | Version (for .NET 8) |
|---------|---------|----------------------|
| Microsoft.EntityFrameworkCore | ORM for database access | 8.x |
| Microsoft.EntityFrameworkCore.SqlServer | SQL Server provider for EF Core | 8.x |
| Microsoft.EntityFrameworkCore.Tools | EF migrations & tooling | 8.x |
| Microsoft.AspNetCore.Authentication.JwtBearer | JWT authentication middleware | 8.0.x |
| System.IdentityModel.Tokens.Jwt | JWT token creation/validation | 6.x |
| Swashbuckle.AspNetCore | Swagger/OpenAPI docs for API | 6.x |
| Microsoft.AspNetCore.Identity.EntityFrameworkCore *(optional)* | Identity-based user management | 8.x |

---

## 🗄 Database

- Default: **SQL Server LocalDB**
- Change connection string in `appsettings.json` to use Azure SQL, SQL Server, or SQLite.

---

## ⚙️ Setup Instructions

### 1️⃣ Clone the repository
```bash
git clone https://github.com/<your-username>/<your-repo>.git
cd <your-repo>/backend
```

### 2️⃣ Install .NET SDK 8
[Download here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### 3️⃣ Install dependencies
```bash
dotnet restore
```

### 4️⃣ Update database
```bash
dotnet ef database update
```

### 5️⃣ Run the API
```bash
dotnet run
```
Backend will start on **`https://localhost:5001`**.

---

## 📜 API Documentation
Once running, Swagger UI is available at:
```
https://localhost:5001/swagger
```

---

## 🧾 License
MIT License © 2025
