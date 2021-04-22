using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
   public class Transaction : _base
    {
        public long Acount_ID { get; set; }
        public Double Amount { get; set; }
        public bool IS_Credit { get; set; }


    }
}
