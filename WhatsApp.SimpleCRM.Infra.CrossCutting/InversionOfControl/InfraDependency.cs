using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace WhatsApp.SimpleCRM.Infra.CrossCutting.InversionOfControl
{
    public static class InfraDependency
    {
        /// <summary>
        /// Adiciona as dependências de infraestrutura
        /// </summary>
        /// <param name="serviceCollection">Coleção de serviços</param>
        /// <returns>Coleção de serviços com as dependências de infraestruturas instaladas</returns>
        public static IServiceCollection AddInfraDependecies(this IServiceCollection serviceCollection)
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
                                                               .WriteTo.Console()
                                                               .WriteTo.File("WhatsApp.SimpleCRM.logs.txt", rollingInterval: RollingInterval.Day)
                                                               .CreateLogger();

            serviceCollection.AddSingleton<ILogger>(Log.Logger);

            return serviceCollection;
        }
    }
}
