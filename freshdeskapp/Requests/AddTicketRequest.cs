using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshdeskapp.Requests
{
    public class AddTicketRequest
    {
        public string Name { get; set; }
        public string Query { get; set; }

       
        public bool Isactive { get; set; }
        public int Id { get;  set; }

        public int ContactsId { get; set; }
    }
}
