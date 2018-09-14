

using System;

namespace DamaCoreCMS.Framework.Core
{
    public class NccInfo
    {
        public static string Name { get; } = "DamaCoreCMS";
        public static string Slogan { get; } = "An ASP.Net MVC Core CMS as Site Engine";
        public static Version Version { get; } = new Version(0, 4, 6, 7);
        public static string Description { get; } = "A Content Management System developed using ASP.NET Core.";
        public static string Website { get; } = "http://DotDamaCoreCMS.org";
        public static string Email { get; } = "info@onnorokomsoftware.com";
        public static string Author { get; } = "DotDamaCoreCMS.org";
        public static string CoreModuleFolder { get; } = "Core";
        public static string ModuleFolder { get; } = "Modules";
        public static string ThemeFolder { get; } = "Themes";
        public static string LogFolder { get; } = "__Logs";
        public static string DevelopedBy { get; } = "OnnoRokom Software Ltd.";
        public static string FrameworkKey { get; } = "X-Framework";
        public static string FrameworkVersionKey { get; } = "X-Framework-Version";
    }
}