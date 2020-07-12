using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WhatsApp.SimpleCRM.Domain.Contracts.Infra.Data
{
    /// <summary>
    /// Contrato do repositório de mensagem
    /// </summary>
    public interface IMessageRepository
    {
        /// <summary>
        /// Envia uma mensagem para um destinatário
        /// </summary>
        /// <param name="recipient">Nome do destinatário no chat</param>
        /// <param name="message">Mensagem a ser enviada</param>
        /// <returns>Operação assíncrona</returns>
        public Task Send(string recipient, string message);

        /// <summary>
        /// Envia um conjunto de mensagens em lote
        /// </summary>
        /// <param name="communications">Conjunto de tuplas contendo destinatário e mensagem</param>
        /// <returns>Operação assíncrona</returns>
        public Task SendBatch(IEnumerable<Tuple<string, string>> communications);
    }
}
