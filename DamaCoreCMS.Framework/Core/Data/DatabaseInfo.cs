﻿

namespace DamaCoreCMS.Framework.Core.Data
{
    public class DatabaseInfo
    {
        public string DatabaseHost { get; set; }
        public string DatabasePort { get; set; }
        public string DatabaseUserName { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseName { get; set; }
        public string TablePrefix { get; set; }
    }
}
