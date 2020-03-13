using Abc.Data.Common;


namespace Abc.Data.Quantity
{
    public sealed class UnitData: DefinedEntityData
    {
        public string MeasureId { get; set; }
    }

    public sealed class CopyOfUniData : DefinedEntityData
    {
        public string MeasureId { get; set; }
    }
}
