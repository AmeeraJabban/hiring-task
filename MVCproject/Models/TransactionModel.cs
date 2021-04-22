using MVCproject.Models._base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCproject.Models
{
    public class TransactionModel :_baseModel
    {
        public long Acount_ID { get; set; }
        public Double Amount { get; set; }
        public bool IS_Credit { get; set; }
    }
}
