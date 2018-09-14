﻿
 
using MediatR;

namespace DamaCoreCMS.Framework.Core.Events.Modules
{
    public class OnModuleActivity : IRequest<ModuleActivity>
    {
        public ModuleActivity Data { get; set; }
        public OnModuleActivity(ModuleActivity data)
        {
            Data = data;
        }
    }
}
