using Application.Common.Interfaces;
using Application.Invoices.ViewModels;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Invoices.Queries
{
    public class GetAllPeopleQuery : IRequest<IEnumerable<People>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllPeopleQuery, IEnumerable<People>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllProductsQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<People>> Handle(GetAllPeopleQuery query, CancellationToken cancellationToken)
            {
                var people = await _context.Peoples.ToListAsync();
                if (people == null)
                {
                    return null;
                }
                return people.AsReadOnly();
            }

        }
    }
}
