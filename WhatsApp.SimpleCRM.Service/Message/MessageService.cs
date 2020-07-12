using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WhatsApp.SimpleCRM.Domain.Contracts.Infra.Data;
using WhatsApp.SimpleCRM.Domain.Contracts.Service.Message;

namespace WhatsApp.SimpleCRM.Service.Message
{
    /// <summary>
    /// Serviço de mensagens
    /// </summary>
    public class MessageService : IMessageService
    {
        /// <summary>
        /// Serviço de log
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Repositório de mensagens
        /// </summary>
        private readonly IMessageRepository _messageRepository;

        public MessageService(ILogger logger, IMessageRepository messageRepository)
        {
            _logger = logger;
            _messageRepository = messageRepository;
        }

        public async Task SendBatch(IEnumerable<Tuple<string, string>> communications)
        {
            await _messageRepository.SendBatch(communications);
        }

        public async Task Send(string recipient, string message)
        {
            await _messageRepository.Send(recipient, message);
        }
    }
}
