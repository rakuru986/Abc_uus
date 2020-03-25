using System.ComponentModel;
using Abc.Facade.Common;

namespace Abc.Facade.Quantity {

    public sealed class UnitFactorView : PeriodView {

        [DisplayName("Unit")]
        public string UnitId { get; set; }

        [DisplayName("System of Units")]
        public string SystemOfUnitsId { get; set; }

        public double Factor { get; set; }

        public string GetId() => $"{SystemOfUnitsId}.{UnitId}";

    }

}
