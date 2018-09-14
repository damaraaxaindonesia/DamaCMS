

using System;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Modules;
using DamaCoreCMS.EasyNews.Models.Entities;

namespace DamaCoreCMS.EasyNews
{
    public class Module : BaseModule, IModule
    {
        public override bool Install(INccSettingsService settingsService, Func<NccDbQueryText, string> executeQuery, Func<Type, bool, int> createUpdateTable)
        {
            try
            {
                createUpdateTable(typeof(Category), false);
                createUpdateTable(typeof(CategoryDetails), false);
                createUpdateTable(typeof(News), false);
                createUpdateTable(typeof(NewsDetails), false);
                createUpdateTable(typeof(NewsCategory), false);
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
                deleteTable(typeof(NewsCategory));
                deleteTable(typeof(NewsDetails));
                deleteTable(typeof(News));
                deleteTable(typeof(CategoryDetails));
                deleteTable(typeof(Category));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
