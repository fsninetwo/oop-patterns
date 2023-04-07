using Microsoft.Extensions.Logging;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Services.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Decorator
{
    public class SimpleServiceLoggingDecorator : ISimpleService
    {
        private readonly ISimpleService _simpleService;
        private readonly ILogger<SimpleServiceLoggingDecorator> _logger;

        public SimpleServiceLoggingDecorator(
            ISimpleService notifierService, 
            ILogger<SimpleServiceLoggingDecorator> logger)
        {
            _simpleService = notifierService;
            _logger = logger;
        }

        public async Task<string> DoSomethingAsync(string message)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = await _simpleService.DoSomethingAsync(message);

            stopwatch.Stop();

            _logger.LogInformation($"Completed in {stopwatch.Elapsed.TotalMilliseconds} ms");
            return result;
        }
    }
}
