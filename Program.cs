var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços necessários
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization(); // 🔹 Adiciona o serviço de autorização

var app = builder.Build();

// Configuração do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); // 🔹 Certifique-se de que está chamando essa linha após a configuração do Swagger
app.MapControllers();

app.Run();
