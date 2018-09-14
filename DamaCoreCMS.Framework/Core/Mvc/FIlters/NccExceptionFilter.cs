

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.Core.Messages;
using System;

namespace DamaCoreCMS.Framework.Core.Mvc.Filters
{
    public class NccGlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger _logger;

        public NccGlobalExceptionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<NccGlobalExceptionFilter>();
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, "Global Exception Filter");
            GlobalMessageRegistry.RegisterMessage(
                new GlobalMessage()
                {
                    For = GlobalMessage.MessageFor.Admin,
                    Registrater = "GlobalExceptionFilter",
                    Text = context.Exception?.Message,
                    Type = GlobalMessage.MessageType.Error
                },
                new TimeSpan(0, 0, 10)
            );
        }
    }
}
