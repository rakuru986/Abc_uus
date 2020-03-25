using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common {

    [TestClass] public class CommonMetricDataTests : AbstractClassTests<CommonMetricData, DefinedEntityData> {

        private class testClass : CommonMetricData { }

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            obj = new testClass();
        }

    }

}
