using System.Collections.Generic;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Quantity {

    [TestClass] public class UnitTests : SealedClassTests<Unit, Metric<UnitData, UnitTerm>> {

        [TestMethod] public void MeasureTest() => isReadOnlyProperty(obj, nameof(obj.Measure), null);

        [TestMethod] public void TermsTest() => isReadOnlyProperty(obj, nameof(obj.Terms), null);

        [TestMethod] public void FactorsTest() => isReadOnlyProperty(obj, nameof(obj.Factors), null);

        [TestMethod] public void TermsIsReadOnlyListTest() =>
            isPropertyTypeOf(obj, nameof(obj.Terms), typeof(IReadOnlyList<UnitTerm>));

        [TestMethod] public void FactorsIsReadOnlyListTest() =>
            isPropertyTypeOf(obj, nameof(obj.Factors), typeof(IReadOnlyList<UnitFactor>));

        [TestMethod] public void CanSetTermsInConstructorTest() {
            var terms = GetRandom.List(() => new UnitTerm(GetRandom.Object<UnitTermData>()));
            obj = new Unit(null, null, terms);
            Assert.AreEqual(terms.Count, obj.Terms.Count);
            for(var i = 0; i < terms.Count; i++) arePropertiesEqual(terms[i].Data, obj.Terms[i].Data);
        }

        [TestMethod] public void CanSetFactorsInConstructorTest() {
            var factors = GetRandom.List(() => new UnitFactor(GetRandom.Object<UnitFactorData>()));
            obj = new Unit(null, null, null, factors);
            Assert.AreEqual(factors.Count, obj.Factors.Count);
            for (var i = 0; i < factors.Count; i++) arePropertiesEqual(factors[i].Data, obj.Factors[i].Data);
        }

    }

}
