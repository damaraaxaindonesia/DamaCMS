

using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using DamaCoreCMS.ImageSlider.Models.Entities;

namespace DamaCoreCMS.ImageSlider.Repositories
{
    public class NccImageSliderRepository : BaseRepository<NccImageSlider, long>
    {
        public NccImageSliderRepository(NccDbContext context) : base(context)
        {
        }
    }
}
