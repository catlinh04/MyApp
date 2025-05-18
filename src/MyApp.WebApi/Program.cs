
using DotNetEnv;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.Validators;
using MyApp.Infrastructure.Data;
using MyApp.WebApi.Extensions;
using MyApp.WebApi.Middlewares;

namespace MyApp.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Load environment variables
            EnvironmentExtensions.LoadEnvironmentVariables(builder.Services);


    builder.Services.AddControllers();
    builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters()
        .AddValidatorsFromAssemblyContaining<OrderCreateRequestValidator>();
            builder.Services.ConfigureServices();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseMiddleware<ExceptionMiddleware>();
            await app.Services.SeedDatabaseAsync();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            // app.UseExceptionHandling();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
