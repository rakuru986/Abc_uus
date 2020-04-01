using Abc.Domain.Common;
using Abc.Data.Quantity;

namespace Abc.Domain.Quantity
{
    public sealed class Unit: Entity<UnitData>
    {
        public Unit(): this(null) { }
        public Unit(UnitData d) : base(d) { }
    }
}
