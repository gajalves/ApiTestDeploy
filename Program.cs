var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var port = builder.Configuration["PORT"];

builder.Services.AddControllers();
builder.WebHost.UseUrls($"http://0.0.0.0:{port};http://localhost:3000");

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
