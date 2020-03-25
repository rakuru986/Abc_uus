using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity {

    public static class UnitFactorViewFactory {

        public static UnitFactor Create(UnitFactorView v) {
            var d = new UnitFactorData();
            Copy.Members(v, d);

            return new UnitFactor(d);
        }

        public static UnitFactorView Create(UnitFactor o) {
            var v = new UnitFactorView();
            Copy.Members(o.Data, v);

            return v;
        }

    }

}
