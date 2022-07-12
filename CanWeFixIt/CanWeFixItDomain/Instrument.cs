using CanWeFixItDomain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeFixItDomain
{
    public class Instrument : BaseDomainEntity
    {
        public string Sedol { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
