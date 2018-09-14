

using Microsoft.AspNetCore.Mvc.Filters;

namespace DamaCoreCMS.Framework.Core.Mvc.Filters
{
    public interface INccActionFilter : IActionFilter
    {
        int Order { get; }
    }
}
