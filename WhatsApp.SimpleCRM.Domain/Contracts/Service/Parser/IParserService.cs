using System;
using System.Collections.Generic;

namespace WhatsApp.SimpleCRM.Domain.Contracts.Service.Parser
{
    /// <summary>
    /// Contrato de serviço de decodificação de arquivo
    /// </summary>
    public interface IParserService
    {
        /// <summary>
        /// Decodifica o arquivo em uma coleção de tuplas que correspondem ao destinatário e a mensagem a ele vinculada
        /// </summary>
        /// <param name="filepath">Caminho do arquivo a ser decodificado</param>
        /// <returns>Coleção de tupla que corresponde ao destinatário e sua mensagem</returns>
        public IEnumerable<Tuple<string, string>> ParseFile(string filepath);
    }
}
