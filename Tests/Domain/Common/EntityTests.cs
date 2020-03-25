using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common {

    [TestClass] public class EntityTests : AbstractClassTests<Entity<MeasureData>, object> {

        private class testClass : Entity<MeasureData> {

            public testClass(MeasureData d = null) : base(d) { }

        }

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod] public void DataTest() {
            isReadOnlyProperty(obj, nameof(obj.Data), null);
        }

        [TestMethod] public void CanSetDataTest() {
            var d = GetRandom.Object<MeasureData>();
            obj = new testClass(d);
            Assert.AreNotSame(d, obj.Data);
            arePropertiesEqual(d, obj.Data);
        }

        [TestMethod] public void CanSetNullDataTest() {
            obj = new testClass();
            Assert.IsNull(obj.Data);
        }

        [TestMethod] public void CantChangeDataElementsTest() {
            obj = new testClass(GetRandom.Object<MeasureData>());
            var d = obj.Data;
            obj.Data.Id = GetRandom.String();
            obj.Data.Name = GetRandom.String();
            obj.Data.Code = GetRandom.String();
            obj.Data.Definition = GetRandom.String();
            obj.Data.ValidFrom = GetRandom.DateTime();
            obj.Data.ValidTo = GetRandom.DateTime();
            arePropertiesEqual(d, obj.Data);
        }

    }

}
