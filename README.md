# WhatsApp Simple CRM 🤝
[![.NET Core 3.1 Badge](https://img.shields.io/badge/-Core%203.1-5C2D91?style=flat-square&logo=.NET&logoColor=white&link=https://dotnet.microsoft.com/download)](https://dotnet.microsoft.com/download) [![WhatsApp Web Badge](https://img.shields.io/badge/-WhatsApp%20Web-25D366?style=flat-square&logo=WhatsApp&logoColor=white&link=https://web.whatsapp.com/)](https://web.whatsapp.com/) [![Microsoft Excel Badge](https://img.shields.io/badge/-Microsoft%20Excel-217346?style=flat-square&logo=Microsoft%20Excel&logoColor=white&link=https://office.live.com/start/Excel.aspx)](https://office.live.com/start/Excel.aspx) [![Version Badge](https://img.shields.io/github/v/release/jpmoura/whatsapp-simple-crm?include_prereleases)](https://github.com/jpmoura/whatsapp-simple-crm/releases/download/v0.0.1-alpha/WhatsApp.SimpleCRM.Console.exe)

Esse projeto se trata de uma aplicação de console multiplataforma construída com .NET Core que visa automatizar o envio de mensagens via [WhatsApp Web](https://web.whatsapp.com/).

Inicialmente ele foi desenvolvido tendo em vista uma comunicação diária com clientes, onde existe a necessidade de um vendedor de enviar um resumo do status dos pedidos de vários clientes. Como a [Business API do WhatsApp](https://www.whatsapp.com/business/api) não atendia aos requisitos necessários, a criação desse projeto tornou-se necessária.

A primeira versão _alpha_ da aplicação para o Windows pode ser baixada [nesse link](https://github.com/jpmoura/whatsapp-simple-crm/releases/download/v0.0.1-alpha/WhatsApp.SimpleCRM.Console.exe)

## 1. Instruções

Para que o programa funcione corretamente, é necessário que exista um arquivo XLSX com o nome **igual** a `comunicações.xlsx`.

A estrutura da planilha é simples, sendo:

| Nome do Contato | Mensagem a ser enviada |
|--|--|
| Cliente Exemplo | Oi cliente exemplo, seu pedido já foi enviado |

Cada linha deve ter em sua primeira coluna o nome do contato ao qual a mensagem será enviada, exatamente como aparece no [WhatsApp Web](https://web.whatsapp.com/), ou seja, com a mesma escrita da agenda do usuário no seu dispositivo móvel. 

**Não é necessário a inclusão de cabeçalhos**, uma vez que todas as linhas serão consideradas já como uma comunicação a ser realizada.

Com o arquivo `comunicações.xlsx` criado, basta colocá-lo no mesmo diretório (pasta) do programa e então executar o próprio programa. Ele irá abrir uma nova janela do navegador Chrome, onde será necessária a única interação por parte do usuário, que é [permitir o uso do WhatsApp Web](https://faq.whatsapp.com/general/download-and-installation/how-to-log-in-or-out).

Após a sincronização o programa irá se encarregar de enviar as mensagens para os contatos presentes no arquivo. Após feito os envios, o próprio programa se encarrega de fazer o _logout_ do [WhatsApp Web](https://web.whatsapp.com/).

Toda execução do programa gera um novo arquivo (caso ele já não exista) chamado `WhatsApp.SimpleCRM.logsAAAAMMDD.txt` onde contém informações sobre a execução do mesmo, como erros que ocorreram, por exemplo. Ele é útil para a realização de análise de erros durante a execução e comportamento do programa.

## 2. TODO

1. Testes unitários
2. Flexibilização de configurações como caminho do arquivo da planilha e ativação/desativação de log bem como o caminho do arquivo
3. Uso de um repositório ou serviço de log remoto (e.g Splunk, Firebase)
4. Tradução dos comentários e README para o inglês para facilitar a contribuição
5. Flexibilização de formatos aceitos (e.g. CSV)
