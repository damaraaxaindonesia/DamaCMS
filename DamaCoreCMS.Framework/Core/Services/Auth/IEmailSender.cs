

using System.Threading.Tasks;

namespace DamaCoreCMS.Framework.Core.Services.Auth
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailConfirmationAsync(string email, string callbackUrl);
    }
}
