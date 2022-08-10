using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Invoices.ViewModels
{
    public class PeopleContactsModel
    {

        public int PeopleId { get; set; }
        public string Name { get; set; }

        public int CountContact { get; set; }

        public IEnumerable<PeopleContactModel> Contacts { get; set; }

    }


    public class PeopleContactModel
    {
        public int Id { get; set; }

        public int? Phone { get; set; }
        public long localtion { get; set; }
       
    }

}


