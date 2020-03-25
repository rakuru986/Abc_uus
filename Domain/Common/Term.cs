using Abc.Data.Quantity;

namespace Abc.Domain.Common {

    public abstract class Term<TData> : Entity<TData>, ITerm where TData: CommonTermData, new(){

        protected Term(TData data) : base(data) {}

        public int Power => data?.Power?? 0;

    }

}