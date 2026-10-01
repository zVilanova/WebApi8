# 🌐 WebApi8

[![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=flat&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/) [![EF Core](https://img.shields.io/badge/EF_Core-512BD4?style=flat&logo=dotnet&logoColor=white)](https://learn.microsoft.com/en-us/ef/core/) [![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server) [![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black)](https://swagger.io/)

Um projeto de estudo construído com ASP.NET Core para praticar os fundamentos de APIs REST, integração com banco de dados e Entity Framework Core.

## Visão Geral

WebApi8 é uma API de gerenciamento de Livros e Autores, criada para consolidar conceitos essenciais de backend usando o ecossistema .NET:

- Uma API REST desenvolvida com C# e .NET 8
- Um relacionamento um-para-muitos entre Autores e Livros (um autor pode ter vários livros)
- Persistência de dados com Entity Framework Core e SQL Server
- Um wrapper de resposta padronizado (`ResponseModel<T>`) retornado por todos os endpoints
- Documentação interativa via Swagger / Swashbuckle

### Stack

| Camada         | Tecnologia                  |
| -------------- | --------------------------- |
| API            | C# / .NET 8 / ASP.NET Core  |
| ORM            | Entity Framework Core       |
| Banco de Dados | SQL Server                  |
| Documentação   | Swagger / Swashbuckle       |

### Formato Padrão de Resposta

Todo endpoint retorna os dados envolvidos em um formato consistente:

```json
{
  "dados": {},
  "mensagem": "",
  "status": true
}
```

### Endpoints da API

#### Livros (`/api/Livro`)

| Método   | Rota                                      | Descrição                          |
| -------- | ----------------------------------------- | ---------------------------------- |
| `GET`    | /api/Livro/ListarLivros                   | Lista todos os livros              |
| `GET`    | /api/Livro/BuscarLivroPorId/{idLivro}     | Busca um livro pelo ID             |
| `GET`    | /api/Livro/BuscarLivroPorIdAutor/{idAutor}| Busca um livro pelo ID do autor    |
| `POST`   | /api/Livro/CriarLivro                     | Cria um novo livro                 |
| `PUT`    | /api/Livro/EditarLivro                    | Atualiza um livro existente        |
| `DELETE` | /api/Livro/ExcluirLivro?idLivro={id}      | Exclui um livro                    |

#### Autores (`/api/Autor`)

| Método   | Rota                                         | Descrição                         |
| -------- | -------------------------------------------- | --------------------------------- |
| `GET`    | /api/Autor/ListarAutores                     | Lista todos os autores            |
| `GET`    | /api/Autor/BuscarAutorPorId/{idAutor}        | Busca um autor pelo ID            |
| `GET`    | /api/Autor/BuscarAutorPorIdLivro/{idLivro}   | Busca o autor de um determinado livro |
| `POST`   | /api/Autor/CriarAutor                        | Cria um novo autor                |
| `PUT`    | /api/Autor/EditarAutor                       | Atualiza um autor existente       |
| `DELETE` | /api/Autor/ExcluirAutor?idAutor={id}         | Exclui um autor                   |

### Exemplo de Payload — POST /api/Autor/CriarAutor

```json
{
  "nome": "Machado",
  "sobrenome": "de Assis"
}
```

### Exemplo de Payload — POST /api/Livro/CriarLivro

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

## Executando Localmente

### Pré-requisitos

- .NET 8 SDK
- SQL Server (instância local ou remota)
- Git

#### Clone o repositório

```bash
git clone https://github.com/zVilanova/WebApi8.git
```

```bash
cd WebApi8
```

#### Configure a connection string

Edite o `appsettings.json` e defina a string `DefaultConnection` apontando para a sua instância do SQL Server.

#### Aplique as migrations

```bash
dotnet ef database update
```

#### Execute a aplicação

```bash
dotnet run
```
