using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    // aqui estamos criando um controller chamado ContatoController
    // aqui temos o apicontroler e o route, para que nossa classe se comporte commo uma api controller
    [ApiController]
    [Route("[controller]")]

    //aqui estamos herdando de controllerbase para que possamos usar os metodos http
    public class ContatoController : ControllerBase
    {
        //atributo privado somente leitura do tipo agenda context
        private readonly AgendaContext _context;

        // criando um construtor que recebe um parametro do tipo agendacontext, no caso o nosso banco de dados
        // repare que criou um import do namespace ModuloAPI.Context
        public ContatoController(AgendaContext context)
        {
            //aqui estamos atribuindo o parametro context recebido ao atributo privado _context
            _context = context;
        }

        //usamos post aqui pq quando criamos estamos enviando uma informacao para o servidor
        [HttpPost]

        //OPeracao Create. aqui estamos criando um metodo chamado create que recebe um parametro do tipo contato
        public IActionResult Create(Contato contato)
        {
            //aqui estamos adicionando o contato recebido ao banco de dados
            _context.Add(contato);

            //aqui estamos salvando as alteracoes no banco de dados
            _context.SaveChanges();

            //aqui estamos retornando um status 201, que significa que o recurso foi criado
            return Ok(contato);

            //depois disso nos damos um dotnet watch run para rodar a aplicacao
            // e testamos no swagger e colocamos um nome e um telefone e clicamos em try it out
            // e depois em execute e verificamos se o status code foi 201
        }

        //usamos get aqui pq estamos solicitando uma informacao do servidor
        [HttpGet("{id}")]

        //Operacao Read. aqui estamos criando um metodo chamado obterporid que recebe um parametro do tipo int
        public IActionResult ObterPorId(int id)
        {
            //Contatos aqui seria a tabela que criamos no banco de dados
            //find aqui seria um metodo que busca um contato pelo id
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                //aqui estamos retornando um status 404, que significa que o recurso nao foi encontrado
                return NotFound();
            }

            //aqui estamos retornando um status 200, que significa que a solicitacao foi bem sucedida
            return Ok(contato);
        }

        //usamos get aqui pq estamos solicitando uma informacao do servidor
        [HttpPut("{id}")]
        
        //metodo atualizar recebe o id e o contato que vamos atualizar
        //Operação UPDATE
        public IActionResult Atualizar(int id, Contato contato)
        {
            //aqui estamos verificando se o id passado e o mesmo que o id do contato
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                //aqui estamos retornando um status 404, que significa que o recurso nao foi encontrado
                return NotFound();

            //aqui estamos atualizando o contato do banco com as informacoes do contato passado
            //esse contatobanco é o contato que esta no banco de dados
            //o contato é o contato que estamos passando que veio do corpo da requisicao
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco); 

        }
    }
}
