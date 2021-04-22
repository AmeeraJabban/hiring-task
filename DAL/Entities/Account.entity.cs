using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Account  :_base
    {
       
        public DateTime Update_DateTime_UTC { get; set; }
        public int Account_number { get; set; }
        public Double Balance{ get; set; }
        public Double Avalible_Balance { get; set; }

        public string Status { get; set; }

    }
}
