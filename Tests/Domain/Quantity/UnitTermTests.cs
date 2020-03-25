using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Quantity {

    [TestClass] public class UnitTermTests : SealedClassTests<UnitTerm, Term<UnitTermData>> {

        [TestMethod] public void UnitTest() => isReadOnlyProperty(obj, nameof(obj.Unit), null);

        [TestMethod] public void CanSetUnitInConstructorTest() {
            var u = new Unit(GetRandom.Object<UnitData>());
            var d = GetRandom.Object<UnitTermData>();
            obj = new UnitTerm(d, u);
            arePropertiesEqual(u.Data, obj.Unit.Data);
        }

    }

}