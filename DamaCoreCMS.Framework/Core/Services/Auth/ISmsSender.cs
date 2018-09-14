

using System.Threading.Tasks;

namespace DamaCoreCMS.Framework.Core.Services.Auth
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
