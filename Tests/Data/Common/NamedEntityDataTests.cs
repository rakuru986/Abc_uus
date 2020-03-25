using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common
{
    [TestClass]
    public class NamedEntityDataTests : AbstractClassTests<NamedEntityData, UniqueEntityData>
    {
        private class testClass : NamedEntityData
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