using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using WhatsApp.SimpleCRM.Domain.Contracts.Service.Core;
using WhatsApp.SimpleCRM.Infra.CrossCutting.InversionOfControl;

namespace WhatsApp.SimpleCRM.Console
{
    public static class Program
    {
        public async static Task Main()
        {
            IServiceCollection serviceCollection = new ServiceCollection().AddInfraDependecies()
                                                                          .AddRepositoryDependencies()
                                                                          .AddServiceDependencies();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            await serviceProvider.GetService<IStartupService>().Start("comunicações.xlsx");
        }
    }
}
