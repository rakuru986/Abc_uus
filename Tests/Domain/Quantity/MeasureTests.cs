using System.Collections.Generic;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Quantity {

    [TestClass] public class MeasureTests : SealedClassTests<Measure, Metric<MeasureData, MeasureTerm>> {

        [TestMethod] public void TermsTest() => isReadOnlyProperty(obj, nameof(obj.Terms), null);

        [TestMethod]
        public void TermsIsReadOnlyListTest() =>
            isPropertyTypeOf(obj, nameof(obj.Terms), typeof(IReadOnlyList<MeasureTerm>));

        [TestMethod]
        public void CanSetTermsInConstructorTest()
        {
            var terms = GetRandom.List(() => new MeasureTerm(GetRandom.Object<MeasureTermData>()));
            obj = new Measure(null, terms);
            Assert.AreEqual(terms.Count, obj.Terms.Count);
            for (var i = 0; i < terms.Count; i++) arePropertiesEqual(terms[i].Data, obj.Terms[i].Data);
        }
    }

}
