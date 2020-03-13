﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Soft.Areas.Quantity.Pages.Units
{
    public class CreateModel : UnitsPage
    {
        public CreateModel(IUnitsRepository r) : base(r)
        {
        }
        public IActionResult OnGet() => Page();

       

      
        public async Task<IActionResult> OnPostAsync()
        {
            if (!await addObject()) return Page();
            return RedirectToPage("./Index");
        }

       
    }
}
