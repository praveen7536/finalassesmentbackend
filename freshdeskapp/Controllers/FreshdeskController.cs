using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using freshdeskapp.Repositories;
using freshdeskapp.Requests;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace freshdeskapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class FreshdeskController : ControllerBase
    {
        private readonly IFreshdeskRepository repository;
        public FreshdeskController(IFreshdeskRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost("AddTicket")]
        public IActionResult AddTicket(AddTicketRequest data)
        {
            return Ok(repository.AddTicket(data));
        }

        [HttpPost("Addcontact")]
        public IActionResult AddContact(AddContactRequest data)
        {
            return Ok(repository.Addcontact(data));
        }
        [HttpGet("GetContacts")]
        public IActionResult GetContacts()
        {
            return Ok(repository.GetContacts());
        }
        [HttpGet("GetTickets")]
        public IActionResult GetTickets()
        {
            return Ok(repository.GetTickets());
        }

        [HttpGet("GetContactsById")]
        public IActionResult GetContactsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(repository.GetContactsById(id));
        }

        [HttpGet("GetTicketsById")]
        public IActionResult GetTicketsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(repository.GetTicketsById(id));
        }

        [HttpPost("UpdateTicket")]
        public IActionResult UpdateTicket(AddTicketRequest data)
        {
            return Ok(repository.UpdateTicket(data));
        }

        [HttpPost("UpdateContact")]
        public IActionResult UpdateContact(AddContactRequest data)
        {
            return Ok(repository.UpdateContact(data));
        }


        [HttpGet("DeleteContact")]
        public IActionResult DeleteContact(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(repository.DeleteContact(id));
        }

        [HttpGet("DeleteTicket")]
        public IActionResult DeleteTicket(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(repository.DeleteTicket(id));
        }
        [HttpGet("auth")]
        public IActionResult auth(string email, string password)
        {
           
            return Ok(repository.auth(email,password));
        }



    }
}
