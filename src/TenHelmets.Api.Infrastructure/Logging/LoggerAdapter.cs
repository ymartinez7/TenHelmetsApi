using Microsoft.Extensions.Logging;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Infrastructure.Logging
{    
    public class LoggerAdapter<T> : IApplicationLogger<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }


        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }

        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }
    }
}
