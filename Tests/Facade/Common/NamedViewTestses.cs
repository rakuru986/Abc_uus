using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Common
{
    [TestClass]
    public class NamedViewTestses : AbstractClassTests<NamedView, UniqueEntityView>
    {
        private class testClass : NamedView
        {
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void NameTest()
        {
            isNullableProperty(() => obj.Name, X => obj.Name= X);
        }
        [TestMethod]
        public void CodeTest()
        {
            isNullableProperty(() => obj.Code, X => obj.Code= X);
        }
    }
}