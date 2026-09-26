# 🌐 WebApi8

[![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=flat&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/) [![EF Core](https://img.shields.io/badge/EF_Core-512BD4?style=flat&logo=dotnet&logoColor=white)](https://learn.microsoft.com/en-us/ef/core/) [![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server) [![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black)](https://swagger.io/)

A study project built with ASP.NET Core to practice the fundamentals of REST APIs, database integration, and Entity Framework Core.

## Overview

WebApi8 is a Book & Author management API, built to consolidate core backend concepts using the .NET ecosystem:

- A REST API developed with C# and .NET 8
- A one-to-many relationship between Authors and Books (one author can have several books)
- Data persistence with Entity Framework Core and SQL Server
- A standardized response wrapper (`ResponseModel<T>`) returned by every endpoint
- Interactive documentation via Swagger / Swashbuckle

### Stack

| Layer          | Technology                 |
| -------------- | --------------------------- |
| API            | C# / .NET 8 / ASP.NET Core  |
| ORM            | Entity Framework Core       |
| Database       | SQL Server                  |
| Documentation  | Swagger / Swashbuckle       |

### Standard Response Format

Every endpoint returns data wrapped in a consistent shape:

```json
{
  "dados": {},
  "mensagem": "",
  "status": true
}
```

### API Endpoints

#### Books (`/api/Livro`)

| Method   | Route                                    | Description                       |
| -------- | ----------------------------------------- | ---------------------------------- |
| `GET`    | /api/Livro/ListarLivros                   | Lists all books                    |
| `GET`    | /api/Livro/BuscarLivroPorId/{idLivro}     | Gets a book by ID                  |
| `GET`    | /api/Livro/BuscarLivroPorIdAutor/{idAutor}| Gets a book by author ID           |
| `POST`   | /api/Livro/CriarLivro                     | Creates a new book                 |
| `PUT`    | /api/Livro/EditarLivro                    | Updates an existing book           |
| `DELETE` | /api/Livro/ExcluirLivro?idLivro={id}      | Deletes a book                     |

#### Authors (`/api/Autor`)

| Method   | Route                                      | Description                     |
| -------- | -------------------------------------------- | --------------------------------- |
| `GET`    | /api/Autor/ListarAutores                     | Lists all authors                |
| `GET`    | /api/Autor/BuscarAutorPorId/{idAutor}        | Gets an author by ID              |
| `GET`    | /api/Autor/BuscarAutorPorIdLivro/{idLivro}   | Gets the author of a given book   |
| `POST`   | /api/Autor/CriarAutor                        | Creates a new author              |
| `PUT`    | /api/Autor/EditarAutor                       | Updates an existing author        |
| `DELETE` | /api/Autor/ExcluirAutor?idAutor={id}         | Deletes an author                 |

### Example Payload — POST /api/Autor/CriarAutor

```json
{
  "nome": "Machado",
  "sobrenome": "de Assis"
}
```

### Example Payload — POST /api/Livro/CriarLivro

```json
{
  "titulo": "Dom Casmurro",
  "autor": {
    "id": 1,
    "nome": "Machado",
    "sobrenome": "de Assis"
  }
}
```

---

## Running Locally

### Prerequisites

- .NET 8 SDK
- SQL Server (local or remote instance)
- Git

#### Clone the repository

```bash
git clone https://github.com/zVilanova/WebApi8.git
```

```bash
cd WebApi8
```

#### Configure the connection string

Edit `appsettings.json` and set the `DefaultConnection` string to point to your SQL Server instance.

#### Apply the migrations

```bash
dotnet ef database update
```

#### Run the application

```bash
dotnet run
```
