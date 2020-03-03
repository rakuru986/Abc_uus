using System;
using System.Collections.Generic;
using System.Text;
using Abc.Data.Common;


namespace Abc.Data.Quantity
{
    public sealed class UniData: DefinedEntityData
    {
        public string MeasureId { get; set; }
    }

    public sealed class CopyOfUniData : DefinedEntityData
    {
        public string MeasureId { get; set; }
    }
}
