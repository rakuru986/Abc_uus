using System.Collections.Generic;
using Abc.Data.Common;

namespace Abc.Domain.Common {

    public abstract class Metric<TData, TTerm> : Entity<TData>
        where TData : CommonMetricData, new()
        where TTerm : ITerm {

        protected internal readonly List<TTerm> metricTerms;

        protected Metric() : this(null) { }

        protected Metric(TData data, List<TTerm> terms = null) : base(data) => metricTerms = terms;

        protected internal IReadOnlyList<TTerm> terms => metricTerms?.AsReadOnly();

    }

}