using ExcelDataReader;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WhatsApp.SimpleCRM.Domain.Contracts.Service.Parser;

namespace WhatsApp.SimpleCRM.Service.Parser
{
    public class ExcelParserService : IParserService
    {
        /// <summary>
        /// Serviço de log
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="logger">Serviço de log</param>
        public ExcelParserService(ILogger logger)
        {
            _logger = logger;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IEnumerable<Tuple<string, string>> ParseFile(string filepath)
        {
            IEnumerable<Tuple<string, string>> communications;

            try
            {
                communications = Parse(filepath);
            }
            catch(Exception e)
            {
                _logger.Error(e, "Erro ao tentar decodificar o arquivo {0} com os destinatários e mensagens", filepath);
                communications = Enumerable.Empty<Tuple<string, string>>();
            }

            return communications;
        }

        /// <summary>
        /// Realiza a decodificação do arquivo
        /// </summary>
        /// <param name="filepath">Caminho do arquivo a ser decodificado</param>
        /// <returns>Coleção de tupla que vincula um destinatário e uma mensagem</returns>
        private IEnumerable<Tuple<string, string>> Parse(string filepath)
        {
            using var stream = File.Open(filepath, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            List<Tuple<string, string>> communications = new List<Tuple<string, string>>();

            while (reader.Read())
            {
                string recipient = reader.GetString(0);
                string message = reader.GetString(1);

                communications.Add(new Tuple<string, string>(recipient, message));
            }

            return communications;
        }
    }
}
