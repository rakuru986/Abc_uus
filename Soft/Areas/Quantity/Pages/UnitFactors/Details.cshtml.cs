using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.UnitFactors {

    public class DetailsModel : UnitFactorsPage {

        public DetailsModel(IUnitFactorsRepository r, IUnitsRepository u, ISystemsOfUnitsRepository s) : base(r, u, s) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue) {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }

    }

}
