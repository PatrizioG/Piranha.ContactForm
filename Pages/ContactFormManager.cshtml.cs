using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Piranha.ContactForm.Models;

namespace Piranha.ContactForm.Pages
{
    public class ContactFormManagerModel : PageModel
    {
        private readonly ContactDbContext _context;

        public IEnumerable<Contact> Contacts;

        public ContactFormManagerModel(ContactDbContext context)
        {
            this._context = context;
        }

        public void OnGet()
        {
            Contacts = _context.Contacts.ToList();
        }
    }
}
