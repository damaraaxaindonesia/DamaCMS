
using Core.Cms.Controllers;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Modules.ShortCode;

namespace NetCoreCCore.Cms.ShortCodes
{
    public class PageShortCode : BaseShortCode
    {
        NccPageService _nccPageService;

        public PageShortCode(NccPageService nccPageService) : base(typeof(CmsPageController), "Page", "ShortCodes/PageRender")
        {
            _nccPageService = nccPageService;
        }

        public override object PrepareViewModel(params object[] paramiters)
        {
            var id = paramiters[0].ToString().Trim();
            var model = _nccPageService.Get(long.Parse(id));
            return model;
        }
    }
}