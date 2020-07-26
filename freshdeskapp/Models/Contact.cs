using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshdeskapp.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Created_On { get; set; }

        public DateTime Updated_On { get; set; }

        public bool Isactive { get; set; }   

        public string Password { get; set; }
       






    }

}
