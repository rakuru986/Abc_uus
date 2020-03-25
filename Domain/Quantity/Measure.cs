using System.Collections.Generic;
using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity {

    public sealed class Measure : Metric<MeasureData, MeasureTerm> {

        public Measure() : this(null) { }

        public Measure(MeasureData data, List<MeasureTerm> terms = null) : base(data, terms) {}

        public IReadOnlyList<MeasureTerm> Terms => terms;

    }

}
