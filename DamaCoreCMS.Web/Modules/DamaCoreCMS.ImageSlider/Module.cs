


using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Modules;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.ImageSlider.Models.Entities;

namespace DamaCoreCMS.Modules.ImageSlider
{
    public class Module : BaseModule, IModule
    {

        public override bool IsMultilangual { get { return false; } }

        public override List<SupportedDatabases> Databases
        {
            get { return new List<SupportedDatabases>() { SupportedDatabases.MySql }; }
        }
        
        public override bool Install(INccSettingsService settingsService, Func<NccDbQueryText, string> executeQuery, Func<Type, bool, int> createUpdateTable)
        {
            try
            {
                createUpdateTable(typeof(NccImageSlider), false);
                createUpdateTable(typeof(NccImageSliderItem), false);
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
                deleteTable(typeof(NccImageSliderItem));
                deleteTable(typeof(NccImageSlider));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }                
    }
}
