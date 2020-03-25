
using Abc.Aids;
using Abc.Core;
using Abc.Data.Quantity;

namespace Abc.Domain.Quantity {

    public sealed class Quantity {

        private readonly Unit unit;

        public Quantity() : this(0, null) { }

        public Quantity(double amount, Unit u) {
            Amount = amount;
            unit = u;
        }

        public double Amount { get; }

        public Unit Unit {
            get {
                if (unit is null) return null;
                var d = new UnitData();
                Copy.Members(unit.Data, d);

                return new Unit(d);
            }

        }

        public override string ToString() {
            return $"{Amount} {getCode()}";
        }

        internal string getCode() {
            if (unit?.Data is null) return Constants.Undefined;
            if (!string.IsNullOrWhiteSpace(unit.Data.Code)) return unit.Data.Code;
            if (!string.IsNullOrWhiteSpace(unit.Data.Name)) return unit.Data.Name;
            if (!string.IsNullOrWhiteSpace(unit.Data.Id)) return unit.Data.Id;

            return Constants.Undefined;
        }

        public Quantity Round(IRoundingPolicy roundingPolicy) {
            var a = roundingPolicy.Round(Amount);

            return new Quantity(a, Unit);
        }

    }

}
