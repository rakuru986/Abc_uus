using System;
using System.Collections.Generic;
using System.Linq;
using Abc.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Abc.Tests
{
    public abstract class BaseClassTest<TClass, TBaseClass>
    {
        private const string notTested = "<{0}> is not tested";
        private const string notSpecified = "Calss is not specified";
        private List<string> members { get; set; }

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

        [TestMethod]
        public void IsTested()
        {
            if (type == null) Assert.Inconclusive(notSpecified);
            var m = GetClass.Members(type, PublicBindingFlagsFor.DeclaredMembers);
            members = m.Select(e => e.Name).ToList();
            removeTested();
            if (members.Count== 0) return;
            Assert.Fail(notTested, members[0]);
        }

        private void removeTested()
        {
            var tests = GetType().GetMembers().Select(e => e.Name).ToList();
            for (var i = members.Count; i > 0; i--)
            {
                var m = members[i - 1] + "Test";
                var isTested = tests.Find(o => o == m);
                if (string.IsNullOrEmpty(isTested)) continue;
                members.RemoveAt(i-1);
            }
        }

        protected static void isNullableProperty<T>(Func<T> get, Action<T> set)
        {
            isProperty(get, set);
            set(default);
            Assert.IsNull(get());
        }

        protected static void isProperty<T>(Func<T> get, Action<T> set)
        {
            var d = (T)GetRandom.Value(typeof(T));
            Assert.AreNotEqual(d, get());
            set(d);
            Assert.AreEqual(d, get());
        }
        protected static void isReadOnlyProperty(object o, string name, object expected)
        {
            var property = o.GetType().GetProperty(name);
            Assert.IsNotNull(property);
            Assert.IsFalse(property.CanWrite);
            Assert.IsTrue(property.CanRead);
            var actual = property.GetValue(o);
            Assert.AreEqual(expected, actual); 



        }

    }
}