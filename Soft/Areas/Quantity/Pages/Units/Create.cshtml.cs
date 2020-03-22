﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Soft.Areas.Quantity.Pages.Units
{
    public class CreateModel : UnitsPage
    {
        public CreateModel(IUnitsRepository r,IMeasuresRepository m) : base(r, m)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }




        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            if (!await addObject()) return Page();
            return Redirect($"/Quantity/Units/Index?fixedFilter={FixedFilter}&fixedValue={FixedValue}");
        }

    }
}
