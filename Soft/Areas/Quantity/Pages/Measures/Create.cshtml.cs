﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Soft.Areas.Quantity.Pages.Measures
{
    public class CreateModel : MeasuresPage
    {
        public CreateModel(IMeasuresRepository r) : base(r)
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
