﻿

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using DamaCoreCMS.Framework.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.i18n
{ 
    public class NccStringLocalizerFactory : IStringLocalizerFactory
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IStringLocalizerFactory _factory;
        public NccStringLocalizerFactory(IStringLocalizerFactory factory, IHttpContextAccessor httpContextAccessor)
        {
            _factory = factory;
            _httpContextAccessor = httpContextAccessor;
        }

        public IStringLocalizer Create(Type resourceSource)
        {
            return new NccStringLocalizer<SharedResource>(_factory,_httpContextAccessor);
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            return new NccStringLocalizer<SharedResource>(_factory, _httpContextAccessor);
        }
    }
}
