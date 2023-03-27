using OOP_Patterns.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSwaggerService();

var app = builder.Build();

app.UseSwaggerService();

app.Run();
