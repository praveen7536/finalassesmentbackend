using freshdeskapp.Models;
using freshdeskapp.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshdeskapp.Repositories
{
    public interface IFreshdeskRepository
    {
         bool AddTicket(AddTicketRequest request);
         bool Addcontact(AddContactRequest request);

         List<Ticket> GetTickets();
         List<Contact> GetContacts();

         List<Ticket> GetTicketsById(int id);
         List<Contact> GetContactsById(int id);



        List<Contact> DeleteContact(int id);
        List<Ticket> DeleteTicket(int id);



         bool UpdateContact(AddContactRequest request);
        bool UpdateTicket(AddTicketRequest request);

        Contact auth(string email, string password);






    }
}
