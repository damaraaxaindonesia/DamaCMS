

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccWebSiteInfo : BaseModel<long>
    {  
        //[Required]
        public string SiteTitle { get; set; }
        public string Tagline { get; set; }
        public string FaviconUrl { get; set; }
        public string SiteLogoUrl { get; set; }

        public string Copyrights { get; set; }
        public string PrivacyPolicyUrl { get; set; }
        public string TermsAndConditionsUrl { get; set; }
        public string Language { get; set; }
    }
}
