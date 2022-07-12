using CanWeFixItApplication.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeFixItApplication.Dtos
{
    public class MarketDataDto : BaseDto
    {
        public long? DataValue { get; set; }
        public int? InstrumentId { get; set; }
        public bool Active { get; set; }
    }
}
