﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Soft.Areas.Quantity.Pages.Units
{
    public class DetailsModel : UnitsPage
    {
        public DetailsModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            await getObject(id);
            return Page();
        }
    }
}
