﻿using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests: SealedClassTest<UnitData, DefinedEntityData>
    {
        [TestMethod]
        public void MeasureIdTest()
        {
            isNullableProperty(() => obj.MeasureId, X => obj.MeasureId = X);
        }
    }
}
