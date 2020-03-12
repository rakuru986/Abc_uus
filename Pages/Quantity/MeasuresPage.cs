using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage : PageModel
    {
        protected internal readonly IMeasuresRepository data;

        protected internal MeasuresPage(IMeasuresRepository r)
        {
            data = r;
            PageTitle = "Measures";
        } 


        [BindProperty]
        public MeasureView Item { get; set; }
        public IList<MeasureView> Items { get; set; }

        public string ItemId => Item.Id;
        public string PageTitle { get; set; }
        public string PageSubTitle { get; set; }
        public string CurrentSort { get; set; } = "Current sort";
        public string CurrentFilter { get; set; } = "Current filter";
        public int PageIndex { get; set; } = 3;

        public int TotalPages { get; set; } = 10;

        protected internal async Task<bool> addObject()
        {
            //TOdO
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.   
            try
            {
                if (!ModelState.IsValid) return false;
                await data.Add(MeasureViewFactory.Create(Item));
            }
            catch
            {
                return false;
            }
            return true;
        }

        protected internal async Task updateObject()
        {
            //TOdO
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.   
            await data.Update(MeasureViewFactory.Create(Item));
        }

        protected internal async Task getObject(string id)
        {
            var o = await data.Get(id);
            Item = MeasureViewFactory.Create(await data.Get(id));
        }

        protected internal async Task deleteObject(string id)
        {
            await data.Delete(id);
        }
    }
}
