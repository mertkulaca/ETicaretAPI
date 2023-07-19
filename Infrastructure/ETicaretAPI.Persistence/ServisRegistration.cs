using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ETicaretAPI.Application.Respositories.ProductRepositories;
using ETicaretAPI.Persistence.Repositories;
using ETicaretAPI.Application.Respositories.CustomerRepositories;
using ETicaretAPI.Application.Respositories.OrderRepositories;

namespace ETicaretAPI.Persistence
{
    public static class ServisRegistration
    {
        
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<Context>(options => options.UseNpgsql(Configuration.ConnectionString) );
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();


        }
    }
}
