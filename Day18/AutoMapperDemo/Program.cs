var builder = WebApplication.CreateBuilder(args);

//dependency root 

builder.Services.AddControllers(); //register all controllers

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();

