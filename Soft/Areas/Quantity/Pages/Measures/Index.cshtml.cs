using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;

namespace Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        

        public IndexModel(IMeasuresRepository r) : base(r)
        {
        }
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            data.SortOrder = sortOrder;
            SearchString = searchString;
            data.SearchString = searchString;
            var l = await data.Get();
            Items = new List<MeasureView>();
            foreach (var e in l)
            {
                Items.Add(MeasureViewFactory.Create(e));
            }
        }

        public string DateSort { get; set; }

        public string NameSort { get; set; } 
       
        public bool HasPreviousPage { get; set; }
       
        public bool HasNextPage { get; set; }

        public int PageIndex { get; set; }

        public string CurrentSort { get; set; }
        
        public string SearchString { get; set; }

        public string CurrentFilter { get; set; }
    }
}
