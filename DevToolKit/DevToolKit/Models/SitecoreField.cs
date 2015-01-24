﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevToolKit.Models
{
    public class SitecoreField : Sitecore.Services.Core.Model.EntityIdentity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string StandardValue { get; set; }
        public string TemplateName { get; set; }
        public string TemplatePath { get; set; }
    }
}