﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Mvc.Attributes
{
    public class PolicyHandler : Attribute
    {
        public string Name { get; set; }
        public PolicyHandler(string name)
        {
            Name = name;
        }
    }
}
