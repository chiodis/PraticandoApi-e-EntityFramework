using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    //primeiro verificar se o nosso banco esta rodando na maquina
    // para criar  uma tabela no banco de dados e adicionar o contexto no nosso banco de dados
    // rodar o comando dotnet-ef migrations add "nome da tabela(migration)" 
    //depois rodar o comando pra atualizar o banco de dados e adicionar o que criamos 
    //dotnet-ef database update
    public class AgendaContext : DbContext
    {
         //faz a ligacao com o banco de dados e cria a tabela de contatos. 
         public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
         {
            //nao precisa escrever nada, aqui recebe a conexao com o banco de dados
        
         }

         //representa uma tabela atraves do dbset
         // tudo que tiver dbset vai ser uma tabela no banco de dados
         // para adiconar temos que ter criado uma entidade antes, na pasta entities e colocar o nome que queremos na tabela
         public DbSet<Contato> Contatos { get; set; }

    }
}