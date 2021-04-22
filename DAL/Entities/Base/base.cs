using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities.Base
{
    public class _base
    {
        public long ID { get; set; }
        public long User_ID { get; set; }
        public DateTime Server_DateTime { get; set; }
        public DateTime DateTime_UTC { get; set; }
        public string Currency { get; set; }
    }
}
