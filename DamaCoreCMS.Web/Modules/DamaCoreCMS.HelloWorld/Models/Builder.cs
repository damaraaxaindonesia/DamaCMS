

using Microsoft.EntityFrameworkCore;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Utility;
using DamaCoreCMS.HelloWorld.Models.Entity;

namespace DamaCoreCMS.ImageSlider.Models
{
    public class Builder : IModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HelloModel>().ToTable(GlobalContext.GetTableName<HelloModel>());
        }
    }
}
