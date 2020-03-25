using Abc.Aids;
using Abc.Data.Common;
using Abc.Domain.Common;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra.Quantity {

    public abstract class
        QuantityRepositoryTests<TRepository, TDomain, TData> : SealedClassTests<TRepository,
            PaginatedRepository<TDomain, TData>>
        where TRepository : PaginatedRepository<TDomain, TData>, new()
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new() {

        protected QuantityDbContext db;

        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<QuantityDbContext>().UseInMemoryDatabase("TestDb").Options;
            db = new QuantityDbContext(options);
        }

        [TestMethod] public void CanSetContextAndSetTest() {
            obj = getObject(db);
            Assert.AreSame(db, obj.db);
            Assert.AreSame(getSet(db), obj.dbSet);
        }

        protected abstract TRepository getObject(QuantityDbContext db);

        protected abstract DbSet<TData> getSet(QuantityDbContext db);

        [TestMethod] public void ToDomainObjectTest() {
            var d = (TData) GetRandom.Object(typeof(TData));
            var o = obj.toDomainObject(d);
            arePropertiesEqual(d, o.Data);
        }

    }

}

