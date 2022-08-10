using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
     public class Contact : AuditEntity
    {
       
    
        public int Id { get; set; }
        public Guid Uuid { get; set; }

        public int? Phone { get; set; }
        public string Email { get; set; }
        public string Addrees { get; set; }
        public double? Location { get; set; }
        public string Info { get; set; }
        public People People { get; set; }
    }
}
