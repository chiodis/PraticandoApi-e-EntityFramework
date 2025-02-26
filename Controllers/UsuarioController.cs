using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


//api que montamos, uma api com uma controller de usuario, colocamos dois metodos e expomos os dois metodos, logo a pessoa pode chamar nossa api e obter determinadas infos, no caso data hora e nome
//o primeiro metodo é para obter data e hora, o segundo é para apresentar o nome
//o primeiro metodo é um get, o segundo é um get com parametro
//o primeiro metodo retorna um objeto com data e hora, o segundo retorna uma mensagem de boas vindas com o nome
//o primeiro metodo retorna um objeto anonimo, o segundo retorna um objeto anonimo com a mensagem
namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase

    {
        //quando acessar essa rota, vai retornar um objeto com o nome do usuário
        [HttpGet("ObterDataHora")]
        
        //vai chamar este método
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá, {nome}! Seja bem-vindo ao sistema!";
            return Ok(new{mensagem});
        }
    }
}