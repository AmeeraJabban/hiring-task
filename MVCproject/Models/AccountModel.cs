using MVCproject.Models._base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCproject.Models
{
    public class AccountModel : _baseModel { 


    public DateTime Update_DateTime_UTC { get; set; }
    public int Account_number { get; set; }
    public Double Balance { get; set; }
    public Double Avalible_Balance { get; set; }

    public string Status { get; set; }
}
}
