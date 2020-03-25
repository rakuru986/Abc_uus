using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity {

    public sealed class UnitFactor : Entity<UnitFactorData> {

        private readonly SystemOfUnits systemOfUnits;

        public UnitFactor() : this(null) { }

        public UnitFactor(UnitFactorData d, SystemOfUnits s = null) : base(d) => systemOfUnits = s;

        public SystemOfUnits SystemOfUnits {
            get {
                if (systemOfUnits is null) return null;
                var d = new SystemOfUnitsData();
                Copy.Members(systemOfUnits.Data, d);

                return new SystemOfUnits(d);
            }

        }

        public double Factor => data?.Factor?? 0D;

    }

}
