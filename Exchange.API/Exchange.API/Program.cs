var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


//HTTP Client
builder.Services.AddHttpClient();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapControllers();

app.Run();

