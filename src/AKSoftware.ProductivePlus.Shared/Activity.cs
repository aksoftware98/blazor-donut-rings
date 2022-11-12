﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKSoftware.ProductivePlus.Shared
{
    public class Activity
    {

        public int TotalUnits { get; set; }

        public DateTime? StartingDate { get; set; }

        public DateTime? EndingDate { get; set; }

        public ActivityType ActivityType { get; set; }

        public string? Notes { get; set; }



    }

}
