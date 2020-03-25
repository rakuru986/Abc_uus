using System;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity {

    [TestClass] public class
        MeasuresRepositoryTests : QuantityRepositoryTests<MeasuresRepository, Measure,
            MeasureData> {

        protected override Type getBaseClass() => typeof(UniqueEntityRepository<Measure, MeasureData>);

        protected override MeasuresRepository getObject(QuantityDbContext c) => new MeasuresRepository(c);

        protected override DbSet<MeasureData> getSet(QuantityDbContext c) => c.Measures;

    }

}