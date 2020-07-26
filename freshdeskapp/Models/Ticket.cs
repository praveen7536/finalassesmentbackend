using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshdeskapp.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string Query { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime Duedate { get; set; }
        public bool Isactive { get; set; }
        public Contact Contact { get; set; }

        public int ContactId { get; set; }

    }
}
