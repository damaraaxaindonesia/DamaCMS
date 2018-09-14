
using Core.Blog.Controllers;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Modules.ShortCode;

namespace Core.Blog.ShortCodes
{
    public class PostShortCode : BaseShortCode
    {
        NccPostService _nccPostService;
        public PostShortCode(NccPostService nccPostService) : base(
            typeof(BlogController),
            "Post",
            "ShortCodes/PostRender")
        {
            _nccPostService = nccPostService;
        }

        public override object PrepareViewModel(params object[] paramiters)
        {
            var id = paramiters[0].ToString().Trim();
            var post = _nccPostService.Get(long.Parse(id));
            return post;
        }
    }
}
