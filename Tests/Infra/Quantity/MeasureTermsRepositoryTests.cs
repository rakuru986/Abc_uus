using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity {

    [TestClass] public class MeasureTermsRepositoryTests : QuantityRepositoryTests<MeasureTermsRepository, MeasureTerm,
        MeasureTermData> {

        protected override MeasureTermsRepository getObject(QuantityDbContext c) => new MeasureTermsRepository(c);

        protected override DbSet<MeasureTermData> getSet(QuantityDbContext c) => c.MeasureTerms;

    }

}