using Application.Common.Interfaces;
using Application.Invoices.Queries;
using Application.Invoices.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Invoices.Handlers
{
    public class GetSistemQueryHandler : IRequestHandler<GetSistemQuery, IList<PeopleVM>>
    {
        private readonly IApplicationDbContext _context;


        public GetSistemQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<PeopleVM>> Handle(GetSistemQuery request, CancellationToken cancellationToken)
        {

            var peoplet = await _context.Peoples.Include(i => i.Contacts)
                .Where(i => i.CreatedBy == request.User).ToListAsync();

            var vm = peoplet.Select(i => new PeopleVM
            {
                Id = i.Id,

                Name = i.Name,

                Contacts = i.Contacts.Select(k => new ContactVM
                {

                    Phone = k.Phone,
                    Location = k.Location


                }


                ).ToList()


            }).ToList();
            var vkt = peoplet.Count();

            return vm;
        }
    }
}