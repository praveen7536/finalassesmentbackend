using freshdeskapp.Models;
using freshdeskapp.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace freshdeskapp.Repositories
{
    public class FreshdeskRepository : IFreshdeskRepository
    {
        private readonly FreshdeskDbContext _db;
        public FreshdeskRepository(FreshdeskDbContext db)
        {
            this._db = db;
        }

        //public bool AddContact(AddContactRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        public bool AddTicket(AddTicketRequest request)
        {
            if (request != null)
            {
                Ticket tickets = new Ticket();
                tickets.Name = request.Name;
                tickets.Query = request.Query;
                tickets.CreatedDate = DateTime.Now;
                tickets.ContactId = request.ContactsId;
                
                tickets.Duedate = DateTime.Now.AddDays(3);
                tickets.Isactive = request.Isactive;

                _db.Tickets.Add(tickets);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Addcontact(AddContactRequest request)
        {
            if (request != null)
            {
                Contact contacts = new Contact();
                contacts.First_Name = request.First_Name;
                contacts.Last_Name = request.Last_Name;
                contacts.Phone = request.Phone;
                contacts.Email = request.Email;
                contacts.Gender = request.Gender;
                contacts.Created_On = DateTime.Now;
                contacts.Updated_On = DateTime.Now;
                contacts.Isactive = request.Isactive;
                
                contacts.Password = request.Password;

                _db.Contacts.Add(contacts);
                _db.SaveChanges();
                return true;






            }
            return false;

        }
        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            tickets = _db.Tickets.ToList();
            return tickets;
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = _db.Contacts.ToList();
            return contacts;
        }

        public List<Ticket> GetTicketsById(int id)
        {
            List<Ticket> tickets = new List<Ticket>();
            tickets = _db.Tickets.Where(a => a.TicketId == id).ToList();
            return tickets;
        }
        public List<Contact> GetContactsById(int id)
        {
            List<Contact> contacts = new List<Contact>();
            contacts = _db.Contacts.Where(a => a.ContactId == id).ToList();
            return contacts;
        }
        public List<Ticket> DeleteTicket(int id)
        {
            Ticket tickets = _db.Tickets.Find(id);
            _db.Tickets.Remove(tickets);
            _db.SaveChanges();
            return GetTicketsById(id);
        }

        public List<Contact> DeleteContact(int id)
        {
            Contact contacts = _db.Contacts.Find(id);
            _db.Contacts.Remove(contacts);
            _db.SaveChanges();
            return GetContactsById(id);

        }
        public bool UpdateContact(AddContactRequest request)
        {
            if (request != null)
            {
                Contact contacts = new Contact();
                contacts.ContactId = request.Id;
                contacts.First_Name = request.First_Name;
                contacts.Last_Name = request.Last_Name;
                contacts.Phone = request.Phone;
                contacts.Email = request.Email;
                contacts.Gender = request.Gender;
                contacts.Updated_On = DateTime.Now;
                contacts.Isactive = request.Isactive;
                
                contacts.Password = request.Password;

                _db.Contacts.Update(contacts);
                _db.SaveChanges();
                return true;






            }
            return false;





        }

        public bool UpdateTicket(AddTicketRequest request)
        {
            if (request != null)
            {
                Ticket tickets = new Ticket();
                tickets.TicketId = request.Id;
                tickets.Name = request.Name;
                tickets.Query = request.Query;
                tickets.Duedate = DateTime.Now.AddDays(3);
                tickets.Isactive = request.Isactive;

                _db.Tickets.Update(tickets);
                _db.SaveChanges();
                return true;
            } 
            return false;
        }
        
        public Contact auth(string email,string password)
        {
            return _db.Contacts.Where(a => a.Email == email && a.Password == password).FirstOrDefault();

        }




       
    }
}




