

using Microsoft.EntityFrameworkCore;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Utility;
using DamaCoreCMS.ImageSlider.Models.Entities;

namespace DamaCoreCMS.ImageSlider.Models
{
    public class Builder : IModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NccImageSlider>().ToTable(GlobalContext.GetTableName<NccImageSlider>());
            modelBuilder.Entity<NccImageSliderItem>().ToTable(GlobalContext.GetTableName<NccImageSliderItem>());
        }
    }
}
