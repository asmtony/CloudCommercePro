using CloudCommercePro.Data.JSONData;
using CloudCommercePro.Interfaces;
using CloudCommercePro.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CloudCommercePro.ConsoleApp.DiSetUp
{
    public class ServiceSetup
    {
        public static void ServiceDISetup(IServiceCollection services)
        {            
            services.AddTransient<IContactData, ContactJSON>();
            services.AddTransient<IContactRepository, ContactRepository>();
        }
    }
}
