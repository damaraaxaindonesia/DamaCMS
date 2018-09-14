﻿

using System;

namespace DamaCoreCMS.Framework.Modules
{
    public interface IModuleMigration
    {
        void Up(Version existingModuleVersion, Version cmsVersion, Func<string, string> executeMigrationQuery);
        void Down(Version existingModuleVersion, Version cmsVersion, Func<string, string> executeMigrationQuery);
    }
}
