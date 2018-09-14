using Microsoft.AspNetCore.Http;

namespace DamaCoreCMS.Framework.Core.Network
{
    public class NetworkUtility
    {
        public static string GetUserIp(HttpContext context)
        {
            return context?.Connection?.RemoteIpAddress?.ToString() +", "+context?.Connection?.LocalIpAddress?.ToString();
        }
    }
}
