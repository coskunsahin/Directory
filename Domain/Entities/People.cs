using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class People:AuditEntity
    {
        public People()
        {
            this.Contacts = new List<Contact>();
        }

        public int Id { get; set; }
        public Guid? uuid { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }


        public DateTime ReportTime { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
