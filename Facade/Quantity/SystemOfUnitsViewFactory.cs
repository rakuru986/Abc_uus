using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity {

    public static class SystemOfUnitsViewFactory {

        public static SystemOfUnits Create(SystemOfUnitsView v) {
            var d = new SystemOfUnitsData();
            Copy.Members(v, d);

            return new SystemOfUnits(d);
        }

        public static SystemOfUnitsView Create(SystemOfUnits o) {
            var v = new SystemOfUnitsView();
            Copy.Members(o.Data, v);

            return v;
        }

    }

}
