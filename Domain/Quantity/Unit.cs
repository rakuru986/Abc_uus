using System.Collections.Generic;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity {

    public sealed class Unit : Metric<UnitData, UnitTerm> {

        private readonly Measure measure;
        private readonly List<UnitFactor> unitFactors;

        public Unit() : this(null) { }

        public Unit(UnitData d, Measure m = null, List<UnitTerm> terms = null, List<UnitFactor> factors = null)
            : base(d, terms) {
            measure = m;
            unitFactors = factors;
        }

        public Measure Measure {
            get {
                if (measure is null) return null;
                var d = new MeasureData();
                Copy.Members(measure.Data, d);

                return new Measure(d);
            }

        }
        public IReadOnlyList<UnitTerm> Terms => terms;

        public IReadOnlyList<UnitFactor> Factors => unitFactors?.AsReadOnly();

    }

}
