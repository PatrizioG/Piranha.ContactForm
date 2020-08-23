using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Piranha.ContactForm.Models;

namespace Piranha.ContactForm
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddContactFormModule(this IServiceCollection services)
        {
            App.Modules.Register<Module>();

            services.AddDbContext<ContactDbContext>(options =>
                {
                    options.UseSqlite("Filename=./ContactForm.db");
                });

            return services;
        }

        public static IApplicationBuilder UseContactFormModule(this IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ContactDbContext>();
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }
            
            return builder;
        }
    }
}
