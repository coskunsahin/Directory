using Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Contact : AuditEntity
    {

        [Key]
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
