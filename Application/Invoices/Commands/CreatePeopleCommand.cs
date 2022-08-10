using Application.Invoices.ViewModels;

using MediatR;
using System;
using System.Collections.Generic;

namespace Application.Invoices.Commands
{
    public class CreatePeopleCommand : IRequest<int>
    {
        public CreatePeopleCommand()
        {
            this.Contacts = new List<ContactVM>();
        }


        public string Name { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }


        public DateTime ReportTime { get; set; }
        public IList<ContactVM> Contacts { get; set; }
    }
}
