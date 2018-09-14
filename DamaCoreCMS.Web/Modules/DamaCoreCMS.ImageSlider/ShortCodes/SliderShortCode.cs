

using DamaCoreCMS.Framework.Modules.ShortCode;
using DamaCoreCMS.ImageSlider.Controllers;
using DamaCoreCMS.ImageSlider.Services;

namespace DamaCoreCMS.ImageSlider.ShortCodes
{
    public class SliderShortCode : BaseShortCode
    {
        NccImageSliderService _nccImageSliderService;

        public SliderShortCode(NccImageSliderService nccImageSliderService) : base(typeof(ImageSliderWidgetController), "NccImageSlider", "ShortCodes/ImageSlider")
        {
            _nccImageSliderService = nccImageSliderService;
        }
        public override object PrepareViewModel(params object[] paramiters)
        {
            var id = paramiters[0].ToString().Trim();
            var model = _nccImageSliderService.Get(long.Parse(id));

            return model;
        }
    }
}