using ModuloAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços necessários
//se quiser mudar basta mudar o  "UseSqlServer" para o banco que desejar e mudar no json o nome da conexao
builder.Services.AddDbContext<AgendaContext>(options=>
 options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))); //  Adiciona o contexto do banco de dados

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization(); //  Adiciona o serviço de autorização

var app = builder.Build();

// Configuração do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); //  Certifique-se de que está chamando essa linha após a configuração do Swagger
app.MapControllers();

app.Run();
