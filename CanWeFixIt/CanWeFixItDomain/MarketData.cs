using CanWeFixItDomain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeFixItDomain
{
    public class MarketData : BaseDomainEntity
    {
        public long? DataValue { get; set; }
        public string Sedol { get; set; }
        public bool Active { get; set; }
    }
}
