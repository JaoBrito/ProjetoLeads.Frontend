# Projeto Frontend - Blazor Web App com Conex�o ao Backend
Este � o frontend de um projeto constru�do com Blazor Web App, que se conecta a uma API Backend ASP.NET Core para gerenciar as entidades Leads. O frontend foi projetado para fornecer uma interface de usu�rio simples e funcional para intera��o com o backend.

## Clonando o Reposit�rio

`git clone https://github.com/JaoBrito/ProjetoLeads.Frontend.git`

## Configura��o do Projeto
1. Restaurando pacotes NuGet
Execute o comando abaixo para restaurar as depend�ncias NuGet do projeto Blazor:

`dotnet restore`

2. Configura��o de Conex�o com o Backend
No arquivo Program.cs, configure a URL do seu backend. Por exemplo:

`builder.Services.AddScoped( sp => new HttpClient { BaseAddress = new Uri( "http://localhost:5000/" ) } );`

Substitua a URL do backend pela URL correta onde a sua API est� hospedada.

3. Configura��o de CORS no Backend
Certifique-se de que o seu backend est� configurado para permitir conex�es CORS do frontend. No arquivo Startup.cs ou Program.cs do seu backend, adicione:

```
builder.Services.AddCors(options =>
{
    options.AddPolicy( "AllowAll", builder =>
     {
         builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader();
     } );
} );

app.UseCors( "AllowAll" );
```

Isso permitir� que o frontend Blazor se conecte ao backend.

## Funcionalidade do Aplicativo
O aplicativo Blazor permite realizar as seguintes opera��es com Leads:

**Criar um novo Lead**: Formul�rio para criar leads com campos como nome, e-mail, etc.

**Listar Leads:** Exibe uma tabela com todos os leads cadastrados.

**Editar Lead:** Permite editar as informa��es de um lead existente.

**Excluir Lead:** Permite excluir um lead do sistema.

As intera��es s�o feitas por meio de chamadas para a API do backend.