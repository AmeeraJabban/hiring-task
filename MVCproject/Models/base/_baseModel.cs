using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCproject.Models._base
{
      public class _baseModel
{
    public long ID { get; set; }
    public long User_ID { get; set; }
    public DateTime Server_DateTime { get; set; }
    public DateTime DateTime_UTC { get; set; }
    public string Currency { get; set; }
}
}
