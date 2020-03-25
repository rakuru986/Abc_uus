﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.Measures {

    public class DeleteModel : MeasuresPage {

        public DeleteModel(IMeasuresRepository r, IMeasureTermsRepository t) : base(r, t) { }

        public async Task<IActionResult> OnGetAsync(string id, string sortOrder, string searchString, int pageIndex,
            string fixedFilter, string fixedValue) {
            await getObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string sortOrder, string searchString, int pageIndex,
            string fixedFilter, string fixedValue) {
            await deleteObject(id, fixedFilter, fixedValue);

            return Redirect(IndexUrl);
        }

    }

}
