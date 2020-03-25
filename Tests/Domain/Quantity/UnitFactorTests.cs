using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Quantity {

    [TestClass] public class UnitFactorTests : SealedClassTests<UnitFactor, Entity<UnitFactorData>> {

        [TestMethod] public void FactorTest() => isReadOnlyProperty(obj, nameof(obj.Factor), 0D);

        [TestMethod] public void SystemOfUnitsTest() => isReadOnlyProperty(obj, nameof(obj.SystemOfUnits), null);

        [TestMethod] public void FactorIsTakenFromDataTest() {
            var d = GetRandom.Object<UnitFactorData>();
            obj = new UnitFactor(d);
            Assert.AreEqual(obj.Factor, d.Factor);
        }

        [TestMethod] public void CanSetSystemOfUnitsInConstructorTest() {
            var s = new SystemOfUnits(GetRandom.Object<SystemOfUnitsData>());
            var d = GetRandom.Object<UnitFactorData>();
            obj = new UnitFactor(d, s);
            arePropertiesEqual(s.Data, obj.SystemOfUnits.Data);
        }

    }

}