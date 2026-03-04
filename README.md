# Praticando API e Entity Framework

## 📝 Resumo do Projeto

Este projeto é uma **API RESTful** desenvolvida em **.NET 8** para fins de aprendizado e prática de conceitos fundamentais de desenvolvimento de APIs web utilizando **ASP.NET Core** e **Entity Framework Core** com **SQL Server**.

### Tecnologias Utilizadas
- **.NET 8.0**
- **ASP.NET Core Web API**
- **Entity Framework Core 9.0.2**
- **SQL Server**
- **Swagger/OpenAPI** (para documentação interativa da API)

## 🎯 O que foi implementado

### 1. Estrutura da API
- Configuração básica de uma Web API com ASP.NET Core
- Integração com Entity Framework Core para persistência de dados
- Configuração do Swagger para documentação e testes da API
- Sistema de autorização básico

### 2. Entidades (Models)
- **Contato**: Entidade que representa um contato na agenda
  - `Id`: Identificador único
  - `Nome`: Nome do contato
  - `Telefone`: Telefone do contato
  - `Ativo`: Status de ativação do contato

### 3. Context (DbContext)
- **AgendaContext**: Contexto do banco de dados que gerencia a conexão e as operações com SQL Server
- Configuração de connection string no `appsettings.json`
- Suporte para diferentes bancos de dados (facilmente configurável)

### 4. Controllers

#### ContatoController
Implementa operações **CRUD** (Create, Read, Update) para gerenciar contatos:
- **POST** `/Contato`: Criar um novo contato
- **GET** `/Contato/{id}`: Obter um contato específico por ID
- **PUT** `/Contato/{id}`: Atualizar um contato existente

#### UsuarioController
Controller de demonstração com endpoints básicos:
- **GET** `/Usuario/ObterDataHora`: Retorna data e hora atual
- **GET** `/Usuario/Apresentar/{nome}`: Retorna uma mensagem de boas-vindas personalizada

### 5. Migrations
- Configuração inicial do banco de dados
- Migration `CriandoTabelaContato` para criação da tabela de contatos

## 🚀 Como Executar

### Pré-requisitos
- .NET 8 SDK instalado
- SQL Server instalado e rodando
- Entity Framework CLI tools instalados: `dotnet tool install --global dotnet-ef`

### Passos
1. Clone o repositório
2. Configure a connection string no arquivo `appsettings.json` ou `appsettings.Development.json`
3. Execute as migrations:
   ```bash
   dotnet ef database update
   ```
4. Execute a aplicação:
   ```bash
   dotnet watch run
   ```
5. Acesse o Swagger em: `https://localhost:{porta}/swagger`

## 💡 Sugestões de Melhorias

### 1. Completar o CRUD
- [ ] **Implementar DELETE**: Adicionar endpoint para deletar contatos
- [ ] **Implementar GET ALL**: Adicionar endpoint para listar todos os contatos com paginação

### 2. Validações
- [ ] Adicionar validações de dados usando **Data Annotations** ou **FluentValidation**
- [ ] Validar campos obrigatórios (Nome, Telefone)
- [ ] Validar formato do telefone
- [ ] Adicionar tratamento de erros mais robusto

### 3. Melhores Práticas de Arquitetura
- [ ] Implementar **Repository Pattern** para abstrair acesso a dados
- [ ] Criar **DTOs (Data Transfer Objects)** para não expor entidades diretamente
- [ ] Implementar **AutoMapper** para mapeamento entre DTOs e entidades
- [ ] Adicionar camada de **Services** para lógica de negócio

### 4. Segurança
- [ ] Implementar autenticação (JWT)
- [ ] Adicionar autorização baseada em roles
- [ ] Implementar rate limiting
- [ ] Adicionar CORS configurável
- [ ] Não expor informações sensíveis nos erros de produção

### 5. Logging e Monitoramento
- [ ] Implementar logging estruturado (Serilog)
- [ ] Adicionar middleware de tratamento de exceções global
- [ ] Implementar health checks
- [ ] Adicionar métricas e telemetria

### 6. Testes
- [ ] Criar testes unitários para controllers e services
- [ ] Criar testes de integração para APIs
- [ ] Configurar testes com banco de dados em memória (InMemory ou SQLite)

### 7. Documentação
- [ ] Adicionar comentários XML para melhorar documentação do Swagger
- [ ] Documentar exemplos de requisições e respostas
- [ ] Criar collection do Postman ou arquivo `.http` mais completo

### 8. Performance
- [ ] Implementar paginação nos endpoints de listagem
- [ ] Adicionar cache (Redis ou Memory Cache)
- [ ] Implementar queries assíncronas em todas as operações de BD
- [ ] Adicionar índices no banco de dados

### 9. Funcionalidades Adicionais
- [ ] Implementar soft delete ao invés de deletar fisicamente
- [ ] Adicionar filtros e busca avançada de contatos
- [ ] Implementar ordenação customizável
- [ ] Adicionar campos de auditoria (CreatedAt, UpdatedAt, CreatedBy, UpdatedBy)
- [ ] Implementar versionamento da API

### 10. DevOps
- [ ] Configurar CI/CD (GitHub Actions, Azure DevOps)
- [ ] Adicionar Docker e docker-compose
- [ ] Configurar diferentes ambientes (Development, Staging, Production)
- [ ] Implementar migrations automáticas no deploy

## 📚 Recursos de Aprendizado

- [Documentação ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core)
- [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core)
- [REST API Best Practices](https://restfulapi.net/)

## 📄 Licença

Projeto para fins educacionais.
