using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public abstract class AbstractClassTest<TClass, TBaseClass>: BaseClassTest<TClass,TBaseClass>
    {
        [TestMethod]
        public void IsAbstarct()
        {
            Assert.IsTrue(type.IsAbstract);
        }
    }
}