using Abc.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Quantity
{
    [TestClass]
    public class MeasureViewFactoryTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize()
        {
            type = typeof(MeasureViewFactory);
        }
    }
}
