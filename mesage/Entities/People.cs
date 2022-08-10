using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{

    public class People 
    {


        public People()
        {
            this.Contacts = new List<Contact>();
        }
        [Key]
        public int Id { get; set; }
        public Guid? uuid { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }


        public DateTime ReportTime { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}

