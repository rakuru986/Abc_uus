﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Data.Common;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public abstract class BaseRepository<TDomain, TData> : ICrudMethods<TDomain>
        where TData : PeriodData, new() 
        where TDomain : Entity<TData>, new()
    {
        protected internal DbContext db;
        protected internal DbSet<TData> dbSet;

        protected BaseRepository(DbContext c, DbSet<TData> s)
        {
            db = c;
            dbSet = s;
        }
        public virtual async Task<List<TDomain>> Get()
        {
            var  query = createSqlQuery();
            var set = await runSqlQueryAsync(query);
            
            return toDomainObjectList(set);
        }

        private List<TDomain> toDomainObjectList(List<TData> set) => set.Select(toDomainObject).ToList();
        

        protected internal abstract TDomain toDomainObject(TData periodData);
        
        internal async Task<List<TData>> runSqlQueryAsync(IQueryable<TData> query) => await query.AsNoTracking().ToListAsync();
        

        protected internal virtual IQueryable<TData> createSqlQuery()
        {
            var query = from s in dbSet select s;
            return query;
        }

        public async Task<TDomain> Get(string id)
        {
            if ( id is null) return new  TDomain();

            var d = await getData(id);
            var obj = new TDomain {Data = d};
            return obj;
        }

        protected abstract Task<TData> getData(string id);
        

        public async Task Delete(string id)
        {
            if (id is null) return;
            var d = await dbSet.FindAsync(id);

            if (d is null) return;

            dbSet.Remove(d);
            await db.SaveChangesAsync();
        }

        public async Task Add(TDomain obj)
        {
            if (obj?.Data is null) return;
            dbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public async Task Update(TDomain obj)
        {
            db.Attach(obj.Data).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MeasureViewExists(MeasureView.Id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                throw;
                //}
            }
        }
    }
}