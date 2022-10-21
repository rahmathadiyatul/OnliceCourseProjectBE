using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoupLocal._3_Data.Data;
using SoupLocal._3_Data.Data.Interface;

namespace SoupLocal._3_Data
{
    public class DataDepedencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
        }
    }
}
