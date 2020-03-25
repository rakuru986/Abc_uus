using Abc.Aids;
using Abc.Core;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Quantity {

    [TestClass] public class QuantityTests : SealedClassTests<Abc.Domain.Quantity.Quantity, object> {

        private class testRoundingPolicy : IRoundingPolicy {

            private readonly double newAmount;

            public testRoundingPolicy(double d) {
                newAmount = d;
            }
            public double Round(double amount) {
                return newAmount;
            }

        }
        private UnitData unitData;
        private Unit unit;
        private double amount;
        private Abc.Domain.Quantity.Quantity quantity;

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            unitData = GetRandom.Object<UnitData>();
            unit = new Unit(unitData);
            amount = GetRandom.Double(-1000, 1000);
            quantity = new Abc.Domain.Quantity.Quantity(amount, unit);
        }

        [TestMethod] public void AmountTest() =>
            isReadOnlyProperty(obj, GetMember.Name<Abc.Domain.Quantity.Quantity>(x => x.Amount), 0.0);

        [TestMethod] public void UnitTest() =>
            isReadOnlyProperty(obj, GetMember.Name<Abc.Domain.Quantity.Quantity>(x => x.Unit), null);

        [TestMethod] public void CanSetProperties() {
            Assert.AreEqual(amount, quantity.Amount);
            Assert.AreNotEqual(unit, quantity.Unit);
            arePropertiesEqual(unit.Data, quantity.Unit.Data);
        }

        [TestMethod] public void CantChangeUnitProperties() {
            quantity.Unit.Data.Name = GetRandom.String();
            quantity.Unit.Data.MeasureId = GetRandom.String();
            quantity.Unit.Data.Code = GetRandom.String();
            quantity.Unit.Data.Definition = GetRandom.String();
            quantity.Unit.Data.Id = GetRandom.String();
            quantity.Unit.Data.ValidFrom = GetRandom.DateTime();
            quantity.Unit.Data.ValidTo = GetRandom.DateTime();
            arePropertiesEqual(unit.Data, quantity.Unit.Data);
        }

        [TestMethod] public void ToStringTest() {
            Assert.AreEqual($"{amount} {unitData.Code}", quantity.ToString());
        }

        [TestMethod] public void ToStringUsesUndefinedWhenNoUnitTest() {
            quantity = new Abc.Domain.Quantity.Quantity(amount, null);
            Assert.AreEqual($"{amount} {Constants.Undefined}", quantity.ToString());
        }

        [TestMethod] public void ToStringUsesUndefinedWhenNoUnitDataTest() {
            quantity = new Abc.Domain.Quantity.Quantity(amount, new Unit(null));
            Assert.AreEqual($"{amount} {Constants.Undefined}", quantity.ToString());
        }

        [TestMethod] public void ToStringUsesNameWhenNoCodeTest() {
            unitData.Code = null;
            quantity = new Abc.Domain.Quantity.Quantity(amount, new Unit(unitData));
            Assert.AreEqual($"{amount} {unitData.Name}", quantity.ToString());
        }

        [TestMethod] public void ToStringUsesIdWhenNoCodeAndNameTest() {
            unitData.Code = null;
            unitData.Name = null;
            quantity = new Abc.Domain.Quantity.Quantity(amount, new Unit(unitData));
            Assert.AreEqual($"{amount} {unitData.Id}", quantity.ToString());
        }

        [TestMethod] public void ToStringUsesUndefinedWhenNoCodeNameAndIdTest() {
            unitData.Code = null;
            unitData.Name = null;
            unitData.Id = null;
            quantity = new Abc.Domain.Quantity.Quantity(amount, new Unit(unitData));
            Assert.AreEqual($"{amount} {Constants.Undefined}", quantity.ToString());
        }

        [TestMethod]
        public void RoundTest() {
            var d = GetRandom.Double();
            var roundingPolicy = new testRoundingPolicy(d);
            obj = quantity;
            var q = obj.Round(roundingPolicy);
            Assert.IsNotNull(q);
            Assert.AreNotEqual(q, obj);
            Assert.AreNotSame(q, obj);
            Assert.AreEqual(d, q.Amount);
            Assert.AreNotSame(q.Unit, obj.Unit);
            arePropertiesEqual(q.Unit.Data, obj.Unit.Data);
        }

    }

}
