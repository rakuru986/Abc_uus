using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Soft.Areas.Quantity.Pages.Measures
{
    public class DetailsModel : MeasuresPage
    {
        public DetailsModel(IMeasuresRepository r) : base(r)
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
