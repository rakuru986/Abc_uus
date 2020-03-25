using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common
{
    [TestClass]
    public class MetricTests: AbstractClassTests<Metric<MeasureData, MeasureTerm>, Entity<MeasureData>>
    {

        private class testClass : Metric<MeasureData, MeasureTerm> { }

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new testClass();
        }


    }
}
