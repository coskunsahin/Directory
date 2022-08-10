using Domain.Entities;
using System;

namespace Application.Invoices.ViewModels
{
    public class ContactVM
    {
        public int Id { get; set; }
        public Guid Uuid { get; set; }

        public int PeopleID { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Addrees { get; set; }
        public long Location { get; set; }
        public string Info { get; set; }
      


    }
}
