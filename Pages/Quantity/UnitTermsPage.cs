using System.Collections.Generic;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Quantity {

    public class UnitTermsPage : CommonPage<IUnitTermsRepository, UnitTerm, UnitTermView, UnitTermData> {

        protected internal UnitTermsPage(IUnitTermsRepository r, IUnitsRepository u) : base(r) {
            PageTitle = "Unit Terms";
            Units = createSelectList<Unit, UnitData>(u);
        }

        public override string ItemId => Item is null ? string.Empty : Item.GetId();

        protected internal override string getPageUrl() => "/Quantity/UnitTerms";

        protected internal override UnitTerm toObject(UnitTermView view) => UnitTermViewFactory.Create(view);

        protected internal override UnitTermView toView(UnitTerm obj) => UnitTermViewFactory.Create(obj);

        public IEnumerable<SelectListItem> Units { get; }

        public string GetUnitName(string unitId) {
            foreach (var m in Units)
                if (m.Value == unitId)
                    return m.Text;

            return "Unspecified";
        }

        protected internal override string getPageSubtitle() {
            return FixedValue is null
                ? base.getPageSubtitle()
                : $"For {GetUnitName(FixedValue)}";
        }

    }

}

