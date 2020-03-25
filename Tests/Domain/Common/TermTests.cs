using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common {

    [TestClass] public class TermTests : AbstractClassTests<Term<MeasureTermData>, Entity<MeasureTermData>> {

        private class testClass : Term<MeasureTermData> {

            public testClass() : this(null) { }

            public testClass(MeasureTermData data) : base(data) { }

        }

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod] public void PowerTest() => isReadOnlyProperty(obj, nameof(obj.Power), 0);

        [TestMethod] public void CanSetPowerInConstructorTest() {
            var d = GetRandom.Object<MeasureTermData>();
            obj = new testClass(d);
            Assert.AreEqual(d.Power, obj.Power);
        }

    }

}
