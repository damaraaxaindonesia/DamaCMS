using System.IO;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace DamaCoreCMS.Framework.Core.Events.Behaviours
{
    public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        public GenericRequestPostProcessor()
        {
            
        }

        public Task Process(TRequest request, TResponse response)
        {
            return Task.FromResult(0);
        }
    }
}