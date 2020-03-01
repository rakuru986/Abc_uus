using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public abstract class BaseClassTest<TClass, TBaseClass>
    {

        protected TClass obj;
        protected Type type;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(TClass);
        }

        [TestMethod]
        public void IsInheritedtest()
        {
            Assert.AreEqual(typeof(TBaseClass), type.BaseType);
        }

        protected static void isNullableProperty<T>(Func<T> get, Action<T> set, Func<T> rnd)
        {
            var d = rnd();
            Assert.AreNotEqual(d, get());
            set(d);
            Assert.AreEqual(d, get());
            //set(null);
            //Assert.IsNull(get());
        }
    }
}