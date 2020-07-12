using System.Threading.Tasks;

namespace WhatsApp.SimpleCRM.Domain.Contracts.Service.Core
{
    /// <summary>
    /// Contrato de serviço que inicia a aplicação
    /// </summary>
    public interface IStartupService
    {
        /// <summary>
        /// Inicia a aplicação
        /// </summary>
        /// <param name="filepath">Caminho do arquivo contendo o os destinatários e suas respectivas mensagens</param>
        public Task Start(string filepath = null);
    }
}
