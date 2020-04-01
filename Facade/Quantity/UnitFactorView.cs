﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abc.Facade.Common;

namespace Abc.Facade.Quantity
{
    public sealed class UnitFactorView:PeriodView
    {
        [Required]
        [DisplayName("Unit")]
        public string UnitId { get; set; }
        [Required]
        [DisplayName("System of units")]
        public string SystemOfUnitsId { get; set; }
        public double Factor { get; set; }
    }
}
