# 📚 BookFlow

Aplicação Full Stack para organizar uma biblioteca pessoal, desenvolvida com **Angular** no frontend e **ASP.NET Core com C#** no backend.

A proposta é permitir que cada usuário cadastre seus livros e acompanhe suas leituras em uma interface simples e intuitiva.

> 🚧 Projeto em desenvolvimento. A estrutura inicial do frontend e do backend está criada; as funcionalidades serão implementadas progressivamente.

## 🎯 Objetivo

Aplicar e demonstrar conhecimentos de desenvolvimento Full Stack, integrando uma interface web a uma API REST e a um banco de dados relacional.

Durante o desenvolvimento, serão trabalhados conceitos como:

- Criação e consumo de APIs REST.
- Orientação a objetos e organização de código.
- Persistência com Entity Framework Core.
- Validação de dados no frontend e no backend.
- Autenticação e autorização.
- Integração de login com Google.
- Versionamento com Git e GitHub.

## 🛠️ Tecnologias

| Camada | Tecnologias |
|---|---|
| Frontend | Angular, TypeScript, HTML e SCSS |
| Backend | C#, ASP.NET Core Web API |
| Banco de dados planejado | SQL Server |
| Persistência planejada | Entity Framework Core |
| Autenticação planejada | Login com Google |
| Versionamento | Git e GitHub |

## ✨ Funcionalidades planejadas

- [ ] Cadastrar livros.
- [ ] Listar os livros cadastrados.
- [ ] Consultar os detalhes de um livro.
- [ ] Editar informações de um livro.
- [ ] Excluir livros.
- [ ] Pesquisar por título ou autor.
- [ ] Organizar livros por status: quero ler, lendo e concluído.
- [ ] Implementar login com Google.
- [ ] Vincular os livros ao usuário autenticado.
- [ ] Criar uma interface responsiva.

## 📁 Estrutura do repositório

- `backend/BookFlow.Api/`: API desenvolvida com ASP.NET Core.
- `frontend/bookflow-web/`: aplicação web desenvolvida com Angular.

O frontend se comunica com a API por requisições HTTP. O backend será responsável pelas regras de negócio e pelo acesso ao banco de dados.

## ▶️ Como executar

### Pré-requisitos

- SDK do .NET compatível com o projeto.
- Node.js e npm compatíveis com a versão do Angular utilizada.
- Angular CLI.

### Backend

Na raiz do repositório, execute:

```bash
cd backend/BookFlow.Api
dotnet restore
dotnet run
```

A URL da API será exibida no terminal.

### Frontend

Em outro terminal, a partir da raiz do repositório:

```bash
cd frontend/bookflow-web
npm install
ng serve
```

Acesse o endereço informado pelo Angular, normalmente:

```text
http://localhost:4200
```

> Nesta etapa inicial, frontend e backend executam separadamente. A integração HTTP e a configuração do banco de dados serão adicionadas nas próximas etapas.

## 🗺️ Etapas do desenvolvimento

1. Criar a estrutura inicial do frontend e do backend.
2. Implementar o cadastro de livros na API.
3. Configurar o SQL Server e o Entity Framework Core.
4. Desenvolver as telas no Angular e integrar com a API.
5. Implementar autenticação e biblioteca individual por usuário.
6. Publicar a aplicação e atualizar a documentação.

## 👨‍💻 Autor

Desenvolvido por **Gabriel San Gregorio** como projeto de estudo e portfólio, com foco na evolução como desenvolvedor Full Stack.
