using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshdeskapp.Models
{
    public class FreshdeskDbContext : DbContext
    {
        public FreshdeskDbContext(DbContextOptions<FreshdeskDbContext> options) : base(options)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public object Ticket { get; internal set; }
        public object Ticketlist { get; internal set; }
    }
}
