

using System.Linq;
using DamaCoreCMS.Framework.Modules.Widgets;
using DamaCoreCMS.ImageSlider.Controllers;
using DamaCoreCMS.ImageSlider.Services;

namespace DamaCoreCMS.ImageSlider.Widgets
{
    public class ImageSliderWidget : Widget
    {
        NccImageSliderService _imageSliderService;        
        string selectedImageSliderName = "";

        public ImageSliderWidget(NccImageSliderService imageSliderService) : base(
            typeof(ImageSliderHomeController),
            "Image Slider",
            "This is a widget to display responsive image slider.",
            "", 
            "Widgets/ImageSlider", 
            "Widgets/ImageSliderConfig" )
        {
            _imageSliderService = imageSliderService;
        }

        public override void InitConfig(dynamic config)
        {   
            selectedImageSliderName = config.name;
        }

        public override object PrepareConfigModel()
        {
            var model = _imageSliderService.LoadAll(true);            
            return model;
        }

        public override object PrepareViewModel()
        {
            var model = _imageSliderService.LoadAll(true, -1, selectedImageSliderName).FirstOrDefault();
            if (selectedImageSliderName.Trim() == "") { model = _imageSliderService.LoadAll().FirstOrDefault(); }            
            return model;
        }
    }
}
