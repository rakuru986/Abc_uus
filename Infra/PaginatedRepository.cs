﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abc.Data.Common;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public abstract class PaginatedRepository<TDomain, TData>: FilteredRepository<TDomain,TData>, IPaging
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()
    {
       
        public int PageIndex { get; set; }
        public int TotalPages => getTotalpages(PageSize);

        
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
        public int PageSize { get; set; } = 5;

        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s)
        {
        }

        internal int getTotalpages(in int pageSize)
        {
            var count = getItemCount();
            var pages = countTotalPages(count, pageSize);
            return pages;
        }

       
        internal int countTotalPages(int count, in int pageSize)
        {
            return (int)Math.Ceiling(count / (double)pageSize);
        }

        private int getItemCount()
        {
            var query = base.createSqlQuery();
            return query.CountAsync().Result;
        }

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query =  base.createSqlQuery();
            query = addSkipAndTake(query);
            return query;
        }

        private IQueryable<TData> addSkipAndTake(IQueryable<TData> query)
        {
            var q = query.Skip(
                    (PageIndex - 1) * PageSize)
                .Take(PageSize);
            return q;
        }
    }
}