using Microsoft.Extensions.Logging;
using OOP_Patterns.Common.Domain.Enums;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;
using OOP_Patterns.Services.Services.Bridge;
using OOP_Patterns.Services.Services.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Proxy
{
    public class MessageProxyService : IMessageProxyService
    {
        private readonly ILogger<SimpleServiceLoggingDecorator> _logger;
        private readonly IMessageService _messageService;

        public MessageProxyService(
            IMessageService messageService,
            ILogger<SimpleServiceLoggingDecorator> logger)
        {
            _logger = logger;
            _messageService = messageService;
        }

        public async Task<string> SendMessageAsync(string message)
        {
            _logger.LogInformation("Proxy service is started");
            var result = _messageService.SendMessageAsync(message);
            _logger.LogInformation("Proxy service is finished");

            return result.Result;
        }
    }
}
