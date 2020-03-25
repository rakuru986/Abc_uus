using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Quantity {

    [TestClass] public class MeasureTermTests : SealedClassTests<MeasureTerm, Term<MeasureTermData>> {

        [TestMethod] public void MeasureTest() => isReadOnlyProperty(obj, nameof(obj.Measure), null);

        [TestMethod] public void CanSetMeasureInConstructorTest() {
            var m = new Measure(GetRandom.Object<MeasureData>());
            var d = GetRandom.Object<MeasureTermData>();
            obj = new MeasureTerm(d, m); 
            arePropertiesEqual(m.Data, obj.Measure.Data);
        }

    }

}