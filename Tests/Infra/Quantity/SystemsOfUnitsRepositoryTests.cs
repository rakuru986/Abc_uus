using System;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity {

    [TestClass] public class
        SystemsOfUnitsRepositoryTests : QuantityRepositoryTests<SystemsOfUnitsRepository, SystemOfUnits,
            SystemOfUnitsData> {

        protected override Type getBaseClass() => typeof(UniqueEntityRepository<SystemOfUnits, SystemOfUnitsData>);

        protected override SystemsOfUnitsRepository getObject(QuantityDbContext c) => new SystemsOfUnitsRepository(c);

        protected override DbSet<SystemOfUnitsData> getSet(QuantityDbContext c) => c.SystemsOfUnits;

    }

}
