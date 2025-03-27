# Projeto Frontend - Blazor Web App com Conexão ao Backend
Este é o frontend de um projeto construído com Blazor Web App, que se conecta a uma API Backend ASP.NET Core para gerenciar as entidades Leads. O frontend foi projetado para fornecer uma interface de usuário simples e funcional para interação com o backend.

![image](https://github.com/user-attachments/assets/26a83f80-dd89-471f-893d-a83eaf33b335)


## Clonando o Repositório

`git clone https://github.com/JaoBrito/ProjetoLeads.Frontend.git`

## Configuração do Projeto
1. Restaurando pacotes NuGet
Execute o comando abaixo para restaurar as dependências NuGet do projeto Blazor:

`dotnet restore`

2. Configuração de Conexão com o Backend
No arquivo Program.cs, configure a URL do seu backend. Por exemplo:

`builder.Services.AddScoped( sp => new HttpClient { BaseAddress = new Uri( "http://localhost:5000/" ) } );`

Substitua a URL do backend pela URL correta onde a sua API está hospedada.

3. Configuração de CORS no Backend
Certifique-se de que o seu backend está configurado para permitir conexões CORS do frontend. No arquivo Startup.cs ou Program.cs do seu backend, adicione:

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

Isso permitirá que o frontend Blazor se conecte ao backend.

## Funcionalidade do Aplicativo
O aplicativo Blazor permite realizar as seguintes operações com Leads:

**Criar um novo Lead**: Formulário para criar leads com campos como nome, e-mail, etc.

**Listar Leads:** Exibe uma tabela com todos os leads cadastrados.

**Editar Lead:** Permite editar as informações de um lead existente.

**Excluir Lead:** Permite excluir um lead do sistema.

As interações são feitas por meio de chamadas para a API do backend.
