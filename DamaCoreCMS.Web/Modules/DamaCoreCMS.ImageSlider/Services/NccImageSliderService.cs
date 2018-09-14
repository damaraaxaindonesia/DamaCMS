

using System.Collections.Generic;
using DamaCoreCMS.ImageSlider.Repositories;
using DamaCoreCMS.ImageSlider.Models.Entities;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.ImageSlider.Services
{
    public class NccImageSliderService : BaseService<NccImageSlider>
    {
        private readonly NccImageSliderRepository _entityRepository;

        public NccImageSliderService(NccImageSliderRepository entityRepository) : base(entityRepository, new List<string>() { "ImageItems" })
        {
            _entityRepository = entityRepository;
        }
    }
}