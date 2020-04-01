using Abc.Data.Common;

namespace Abc.Data.Quantity
{
    public abstract class CommonTermData : PeriodData
    {
        public int Power { get; set; }

        public string MasterId { get; set; }
        public string TermId { get; set; }
    }
}
