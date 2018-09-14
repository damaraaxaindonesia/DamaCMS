


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.Core.Mvc.Attributes;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;
using DamaCoreCMS.Framework.Core.Mvc.Views;
using DamaCoreCMS.Framework.Core.Services;
using Core.Admin.Models.Dto;

namespace Core.Admin.Controllers
{
    [AdminMenu(Name = "Module", IconCls = "fa-tasks", Order = 6)]
    public class StoreSettingsController : NccController
    {
        INccSettingsService _nccSettingsService;
        private ILogger<StoreSettingsController> _logger;
        StoreSettings storeSettings;
        public StoreSettingsController(INccSettingsService nccSettingsService, ILoggerFactory factory)
        {
            _nccSettingsService = nccSettingsService;
            _logger = factory.CreateLogger<StoreSettingsController>();
            storeSettings = _nccSettingsService.GetByKey<StoreSettings>() ?? new StoreSettings();
        }

        [AdminMenuItem(Name = "Store Settings", IconCls = "fa-laptop", Order = 3)]
        public ActionResult Index()
        {
            return View(storeSettings);
        }

        [HttpPost]
        public ActionResult Index(StoreSettings model)
        {
            _nccSettingsService.SetByKey(model);
            ShowMessage("Settings Updated Successfully", MessageType.Success);
            return View(model);
        }
    }
}