using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Common
{
    [TestClass]
    public class UniqueEntityViewTestses : AbstractClassTests<UniqueEntityView, PeriodView>
    {
        private class testClass : UniqueEntityView
        {
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void IdTest()
        {
            isNullableProperty(() => obj.Id, X => obj.Id = X);
        }
    }
}