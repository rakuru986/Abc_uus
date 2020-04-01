﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abc.Aids;
using Abc.Data.Common;
using Abc.Facade.Common;

namespace Abc.Facade.Quantity
{
    public abstract class CommonTermView: PeriodView
    {
        [Required]
        [DisplayName("Term")]
        public string TermId { get; set; }
        public int Power { get; set; }

    }
}