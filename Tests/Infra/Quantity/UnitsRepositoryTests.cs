using System;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity {

    [TestClass] public class UnitsRepositoryTests : QuantityRepositoryTests<UnitsRepository, Unit,
        UnitData> {

        protected override Type getBaseClass() => typeof(UniqueEntityRepository<Unit, UnitData>);

        protected override UnitsRepository getObject(QuantityDbContext c) => new UnitsRepository(c);

        protected override DbSet<UnitData> getSet(QuantityDbContext c) => c.Units;

    }

}