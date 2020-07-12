using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WhatsApp.SimpleCRM.Domain.Contracts.Service.Message
{
    /// <summary>
    /// Contrato do serviço de mensagem
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        /// Envia uma mensagem
        /// </summary>
        /// <param name="recipient">Destinatário</param>
        /// <param name="message">Mensagem</param>
        /// <returns>Operação assíncrona</returns>
        public Task Send(string recipient, string message);

        /// <summary>
        /// Envia um lote de mensagens em uma única interção
        /// </summary>
        /// <param name="communications">Conjunto de tuplas que contém o destinatário e a mensagem</param>
        /// <returns>Operação assíncrona</returns>
        public Task SendBatch(IEnumerable<Tuple<string, string>> communications);
    }
}
