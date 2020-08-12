using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Piranha.ContactForm
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddContactFormModule(this IServiceCollection services)
        {
            App.Modules.Register<Module>();

            return services;
        }

        public static IApplicationBuilder UseContactFormModule(this IApplicationBuilder builder)
        {

            return builder;
        }
    }
}
