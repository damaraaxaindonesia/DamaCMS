

using Microsoft.EntityFrameworkCore;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.EasyNews.Models.Entities;
using DamaCoreCMS.Framework.Utility;

namespace DamaCoreCMS.EasyNews.Models
{
    public class Builder : IModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable(GlobalContext.GetTableName<Category>());
            modelBuilder.Entity<CategoryDetails>().ToTable(GlobalContext.GetTableName<CategoryDetails>());
            modelBuilder.Entity<News>().ToTable(GlobalContext.GetTableName<News>());
            modelBuilder.Entity<NewsDetails>().ToTable(GlobalContext.GetTableName<NewsDetails>());

            modelBuilder.Entity<NewsCategory>(b =>
            {
                b.ToTable(GlobalContext.GetTableName<NewsCategory>());
                b.HasKey(bc => new { bc.CategoryId, bc.NewsId });
            });

            modelBuilder.Entity<NewsCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(b => b.NewsList)
                .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.Entity<NewsCategory>()
                .HasOne(bc => bc.News)
                .WithMany(c => c.CategoryList)
                .HasForeignKey(bc => bc.NewsId);
        }
    }
}
