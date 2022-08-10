using Application.Common.Interfaces;
using Application.Invoices.Queries;
using Application.Invoices.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;

namespace Application.Invoices.Handlers
{
    public class GetAnaQueryHandler : IRequestHandler<GetAnaQuery, IList<PeopleVM>>
    {
        private readonly IApplicationDbContext _context;


        public GetAnaQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<PeopleVM>> Handle(GetAnaQuery request, CancellationToken cancellationToken)
        {
            var peoplet = await _context.Peoples.Include(i => i.Contacts)
                .Where(i => i.CreatedBy == request.User).ToListAsync();
            var vm = peoplet.Select(i => new PeopleVM
            {

                PeopleID = i.PeopleID,
                Name = i.Name,
                LastName = i.Name,
                Company = i.Name,
               
                Contacts = i.Contacts.Select(k => new ContactVM
                {
                    Phone = k.Phone,
                    Location = k.Location,
                    Addrees = k.Addrees,

                }


                ).OrderByDescending(k => k.Location).ToList()


            }
            ).ToList();


            return vm;
        }






    }

}