using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common
{
    [TestClass]
    public class DefinedEntityDataTests : AbstractClassTest<DefinedEntityData, NamedEntityData>
    {
        private class testClass : DefinedEntityData
        {
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new  testClass();
        }

        [TestMethod]
        public void DefinitionTest()
        {
           isNullableProperty(()=>obj.Definition, X=> obj.Definition = X);
        }
    }
}