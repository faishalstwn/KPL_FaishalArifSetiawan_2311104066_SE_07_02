using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Menambahkan layanan untuk controller
builder.Services.AddControllers();

// Menambahkan layanan Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Mengonfigurasi pipeline HTTP request
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Mengaktifkan middleware Swagger
    app.UseSwaggerUI(); // Mengaktifkan Swagger UI di /swagger
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
