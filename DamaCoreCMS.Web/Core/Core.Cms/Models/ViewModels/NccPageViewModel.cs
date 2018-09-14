﻿

using DamaCoreCMS.Framework.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Cms.Models.ViewModels
{
    public class NccPageViewModel : NccPage
    {
        [MaxLength(int.MaxValue)]
        public string PageContent { get; set; }
    }
}
