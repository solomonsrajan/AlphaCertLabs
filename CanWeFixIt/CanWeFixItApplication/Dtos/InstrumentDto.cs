using CanWeFixItApplication.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeFixItApplication.Dtos
{
    public class InstrumentDto : BaseDto
    {
        public string Sedol { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
