using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
   public class User
    {
        public long ID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string imagepath { get; set; }

        public string Status { get; set; }
        public DateTime DOF { get; set; }
        public DateTime Server_DateTime { get; set; }
        public DateTime DateTime_UTC { get; set; }
        public DateTime Update_DateTime_UTC { get; set; }
        public DateTime Last_login_DateTime_UTC { get; set; }

    }
}
