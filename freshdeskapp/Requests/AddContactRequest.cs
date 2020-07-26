using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshdeskapp.Requests
{
    public class AddContactRequest
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
      
        public bool Isactive { get; set; }
       
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
