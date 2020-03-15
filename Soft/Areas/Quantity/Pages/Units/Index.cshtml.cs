using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {
        

        public IndexModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            await getList(sortOrder,currentFilter,  searchString,pageIndex);

        }

    }
}
