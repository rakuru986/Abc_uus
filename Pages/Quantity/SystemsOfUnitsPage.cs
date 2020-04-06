﻿using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Pages.Quantity
{
    public class SystemsOfUnitsPage : CommonPage<ISystemsOfUnitsRepository, SystemOfUnits, SystemOfUnitsView, SystemOfUnitsData>
    {
        protected internal SystemsOfUnitsPage(ISystemsOfUnitsRepository r) : base(r)
        {
            PageTitle = "Measure Terms";
        }


        public override string ItemId => Item.Id;
        
        protected internal override string getPageUrl() => "/QuantitySystemOfUnits";


        protected internal override SystemOfUnits toObject(SystemOfUnitsView view)
        {
            return SystemOfUnitsViewFactory.Create(view);
        }

        protected internal override SystemOfUnitsView toView(SystemOfUnits obj)
        {
            return SystemOfUnitsViewFactory.Create(obj);
        }
    }
}
