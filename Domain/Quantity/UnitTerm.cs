using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{

    public sealed class UnitTerm : Term<UnitTermData>
    {

        private readonly Unit unit;

        public UnitTerm() : this(null) { }

        public UnitTerm(UnitTermData data, Unit u = null) : base(data) => unit = u;

        public Unit Unit
        {
            get
            {
                if (unit is null) return null;
                var d = new UnitData();
                Copy.Members(unit.Data, d);

                return new Unit(d);
            }

        }

    }

}