using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity
{

    [TestClass]
    public class UnitTermsRepositoryTests : QuantityRepositoryTests<UnitTermsRepository, UnitTerm,
        UnitTermData>
    {


        protected override UnitTermsRepository getObject(QuantityDbContext c) => new UnitTermsRepository(c);

        protected override DbSet<UnitTermData> getSet(QuantityDbContext c) => c.UnitTerms;

    }

}