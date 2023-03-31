using OOP_Patterns.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependencyInjections();
builder.Services.AddMvc();
builder.Services.AddSwaggerService();

var app = builder.Build();

app.UseRouting();
app.UseSwaggerService();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
