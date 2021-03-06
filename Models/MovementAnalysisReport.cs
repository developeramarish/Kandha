﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NibsMVC.Models
{
    public class MovementAnalysisReport
    {
        public int id { get; set; }
        public int RawMaterialId { get; set; }
        public string RawMaterialName { get; set; }
    
        public string DateFrom { get; set; }
        public string DateTo { get; set; }

        public string Type { get; set; }
    }

    public class ingrediantReport
    {
        public int id { get; set; }
        public int MenuCategoryId { get; set; }
        public int MenuItemId { get; set; }

        public int SubItemId { get; set; }
        public int RawCategoryId { get; set; }
        public int RawMaterialId { get; set; }
        public string RawMaterialName { get; set; }
        
        public string Type { get; set; }
    }
}