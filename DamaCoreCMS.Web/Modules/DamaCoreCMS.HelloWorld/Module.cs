

using Microsoft.Extensions.DependencyInjection;
using DamaCoreCMS.Framework.Modules;
using System;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Core.Data;
using PaulMiami.AspNetCore.Mvc.Recaptcha;
using DamaCoreCMS.HelloWorld.Models.Entity;

namespace DamaCoreCMS.Modules.HelloWorld
{
    public class Module : BaseModule, IModule
    {
        public string Area { get { return "DamaCoreCMS"; } }
        
        public override void Init(IServiceCollection services, INccSettingsService nccSettingsService)
        {
            //You can also register your services and repositories here.
            services.AddRecaptcha(new RecaptchaOptions
            {
                SiteKey = "6Le8bjoUAAAAADHJ5l_sAKkAv7tIQlVP01-vxOnz",
                SecretKey = "6Le8bjoUAAAAAFC4WEBDN61tzFzBecIjh_xJagUO"
            });
        }
        
        public override bool Install(INccSettingsService settingsService, Func<NccDbQueryText, string> executeQuery, Func<Type, bool, int> createUpdateTable)
        {
            try
            {
                createUpdateTable(typeof(HelloModel), false);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        
        public override bool RemoveTables(INccSettingsService settingsService, Func<NccDbQueryText, string> executeQuery, Func<Type, int> deleteTable)
        {
            try
            {
                deleteTable(typeof(HelloModel));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
