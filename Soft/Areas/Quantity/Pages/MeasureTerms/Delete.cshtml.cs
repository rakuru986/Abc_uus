﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Soft.Areas.Quantity.Pages.MeasureTerms
{
    public class DeleteModel : MeasureTermsPage
    {
        public DeleteModel(IMeasureTermsRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await deleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }
}