using Microsoft.Extensions.DependencyInjection;
using WhatsApp.SimpleCRM.Domain.Contracts.Service.Core;
using WhatsApp.SimpleCRM.Domain.Contracts.Service.Message;
using WhatsApp.SimpleCRM.Domain.Contracts.Service.Parser;
using WhatsApp.SimpleCRM.Service.Core;
using WhatsApp.SimpleCRM.Service.Message;
using WhatsApp.SimpleCRM.Service.Parser;

namespace WhatsApp.SimpleCRM.Infra.CrossCutting.InversionOfControl
{
    /// <summary>
    /// Dependências de serviço
    /// </summary>
    public static class ServiceDependency
    {
        /// <summary>
        /// Adiciona dependências de serviços
        /// </summary>
        /// <param name="serviceCollection">Coleção de serviços</param>
        /// <returns>Coleção de serviços com as dependências da camada de serviços adicionadas</returns>
        public static IServiceCollection AddServiceDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMessageService, MessageService>();
            serviceCollection.AddSingleton<IParserService, ExcelParserService>();
            serviceCollection.AddSingleton<IStartupService, StartupService>();

            return serviceCollection;
        }
    }
}
