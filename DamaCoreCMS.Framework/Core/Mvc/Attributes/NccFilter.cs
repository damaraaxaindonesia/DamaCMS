

using System;

namespace DamaCoreCMS.Framework.Core.Mvc.Attributes
{
    /// <summary>
    /// Attribute for identifying NccAuthRequireHandler
    /// </summary>
    public class NccFilter : Attribute
    {
        private readonly int order;

        /// <summary>
        /// Takes unique id and display name of the handler. Which display name will show at admin panel user's permission giveing page.
        /// </summary>
        /// <param name="Order">Execution order</param>
        public NccFilter(int Order)
        {
            order = Order;
        }
    } 
}
