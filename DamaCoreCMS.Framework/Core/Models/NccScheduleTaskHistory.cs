

using DamaCoreCMS.Framework.Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccScheduleTaskHistory : BaseModel<long>
    {
        public string TaskId { get; set; }
        public string TaskType { get; set; }
        public string TaskOf { get; set; }
        public string TaskCreator { get; set; }
        public string Data { get; set; }
    }
}
