using Microsoft.EntityFrameworkCore;

namespace Piranha.ContactForm.Models
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {

        }
    }
}
