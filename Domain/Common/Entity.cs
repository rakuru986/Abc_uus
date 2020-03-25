﻿using Abc.Aids;
using Abc.Data.Common;

namespace Abc.Domain.Common {

    public abstract class Entity<TData> where TData : PeriodData, new() {

        protected readonly TData data;

        protected internal Entity(TData d = null) => data = d;

        public TData Data {
            get {
                if (data is null) return null;
                var d = new TData();
                Copy.Members(data, d);

                return d;
            }
        }

    }

}
