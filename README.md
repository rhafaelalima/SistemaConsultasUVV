# Sistema de Gestão de Consultas UVV

Projeto desenvolvido para a disciplina de Desenvolvimento Web Back-end (UVV).

## 🚀 Tecnologias Utilizadas
- C# / ASP.NET Core MVC
- Entity Framework Core (Code First)
- SQL Server Express
- Bootstrap 5

## 🛠️ Como Executar o Projeto

1. Configurar a *Connection String* no arquivo `appsettings.json` apontando para a sua instância local do SQL Server.
2. Executar as migrações para criar e atualizar o banco de dados:
   - **Via Terminal / VS Code (.NET CLI):**
     ```bash
     dotnet ef database update
     ```
   - **Via Visual Studio (Console do Gerenciador de Pacotes):**
     ```powershell
     Update-Database
     ```
3. Executar o projeto:
   ```bash
   dotnet run
