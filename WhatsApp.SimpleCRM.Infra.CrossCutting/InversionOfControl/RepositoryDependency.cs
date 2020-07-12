using Microsoft.Extensions.DependencyInjection;
using WhatsApp.SimpleCRM.Domain.Contracts.Infra.Data;
using WhatsApp.SimpleCRM.Infra.Data.Repositories;

namespace WhatsApp.SimpleCRM.Infra.CrossCutting.InversionOfControl
{
    /// <summary>
    /// Dependências de repositório
    /// </summary>
    public static class RepositoryDependency
    {
        /// <summary>
        /// Método de extensão que adiciona as dependências de repositórios
        /// </summary>
        /// <param name="serviceCollection">Coleção de serviços</param>
        /// <returns>Coleção de serviços com as dependências de repositórios adicionadas</returns>
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMessageRepository, SeleniumMessageRepository>();

            return serviceCollection;
        }
    }
}
