
using Microsoft.EntityFrameworkCore;
using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.Implementaciones.Repositorios;
using Sistema_de_Inventario.Implementaciones.Servicios;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<InventorySystemContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IServicioCategoria, ServicioCategoria>();
            builder.Services.AddScoped<IRepositorioCategoria, RepositorioCategoria>();
            builder.Services.AddScoped<IServicioPedido, ServicioPedido>();
            builder.Services.AddScoped<IRepositorioPedido, RepositorioPedido>();
            builder.Services.AddScoped<IServicioProducto, ServicioProducto>();
            builder.Services.AddScoped<IRepositorioProducto, RepositorioProducto>();
            builder.Services.AddScoped<IServicioProveedor, ServicioProveedor>();
            builder.Services.AddScoped<IRepositorioProveedor, RepositorioProveedor>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
