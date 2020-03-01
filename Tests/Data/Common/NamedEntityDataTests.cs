using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class NamedEntityDataTests : AbstractClassTest<NamedEntityData, UniqueEntityData>
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
    }
}