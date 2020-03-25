using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity {

    [TestClass] public class UnitFactorsRepositoryTests : QuantityRepositoryTests<UnitFactorsRepository, UnitFactor,
        UnitFactorData> {


        protected override UnitFactorsRepository getObject(QuantityDbContext c) => new UnitFactorsRepository(c);

        protected override DbSet<UnitFactorData> getSet(QuantityDbContext c) => c.UnitFactors;

    }

}