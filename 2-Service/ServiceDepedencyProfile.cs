using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoupLocal._2_Service.Service;
using SoupLocal._2_Service.Service.Interface;

namespace SoupLocal._2_Service
{
    public class ServiceDepedencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<ICartService, CartService>();
        }
    }
}
