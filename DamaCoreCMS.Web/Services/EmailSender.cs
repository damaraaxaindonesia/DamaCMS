
// For more details see https://go.microsoft.com/fwlink/?LinkID=532713
using DamaCoreCMS.Framework.Core.Services.Auth;
using System;
using System.Threading.Tasks;

namespace DamaCoreCMS.Web.Services { 
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }

        public Task SendEmailConfirmationAsync(string email, string callbackUrl)
        {
            throw new NotImplementedException();
        }
    }
}
