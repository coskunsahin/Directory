using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Invoices.Queries
{
    public class GetLocalQuery : IRequest<Contact>
    {
        public double? lo { get; set; }

        public class GetLocalQueryHandler : IRequestHandler<GetLocalQuery, Contact>
        {
            private readonly IApplicationDbContext _context;
            public GetLocalQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<Contact> Handle(GetLocalQuery query, CancellationToken cancellationToken)
            {
                var ink = _context.Contacts.Include(x => x.People).ToList();
                
                
                var Contact = _context.Contacts.Where(a => a.Location == query.lo).Select(k => new Contact { Phone = k.Phone, Addrees = k.Addrees ,Location=k.Location }).OrderBy(k=>k.Location).FirstOrDefault();
                if (Contact == null) return null;
                return Contact; 
            }
        }
    }
}
