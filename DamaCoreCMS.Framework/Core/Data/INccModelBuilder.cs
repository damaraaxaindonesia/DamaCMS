

using Microsoft.EntityFrameworkCore;

namespace DamaCoreCMS.Framework.Core.Data
{
    public interface IModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}
