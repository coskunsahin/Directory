using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.Invoices.ViewModels
{
    public class PeopleVM
    {
       

        public PeopleVM()
        {
            this.Contacts = new List<ContactVM>();
        }

        public int PeopleID { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

       

        public DateTime ReportTime { get; set; }
        public List<ContactVM> Contacts { get; set; }
    }
}


