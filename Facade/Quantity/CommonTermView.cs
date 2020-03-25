using System.ComponentModel;
using Abc.Facade.Common;

namespace Abc.Facade.Quantity {

    public abstract class CommonTermView : PeriodView {

        public int Power { get; set; }

        [DisplayName("Term")]
        public string TermId { get; set; }

        [DisplayName("Metric")]
        public string MasterId { get; set; }

        public string GetId() => $"{MasterId}.{TermId}";

    }

}
