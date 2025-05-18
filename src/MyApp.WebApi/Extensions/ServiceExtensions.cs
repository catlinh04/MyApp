using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.DTOs.OrderDto.Requests;
using MyApp.Application.Interfaces;
using MyApp.Application.Mappings;
using MyApp.Application.Services;
using MyApp.Application.Validators;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;
using MyApp.Infrastructure.Repositories.Common;
using MyApp.Infrastructure.Services;

namespace MyApp.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(OrderMappingProfile));

            // register repositories
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IEmailSender, EmailSender>();

            // register generic repository
            services.AddScoped(typeof(IGenericRepository<,>), typeof(CrudRepositoryBase<,>));

            // register services
            services.AddScoped<OrderService>();
            services.AddScoped<ItemService>();

            // register validators
            // services.AddValidatorsFromAssemblyContaining<OrderCreateRequestValidator>();
            // services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<OrderCreateRequestValidator>();



        }
    }
}