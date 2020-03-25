using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity {

    public sealed class MeasureTerm : Term<MeasureTermData> {

        private readonly Measure measure;

        public MeasureTerm() : this(null) { }

        public MeasureTerm(MeasureTermData data, Measure m= null) : base(data) => measure = m;

        public Measure Measure {
            get {
                if (measure is null) return null;
                var d = new MeasureData();
                Copy.Members(measure.Data, d);

                return new Measure(d);
            }

        }

    }

}


