using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Invoices.Queries
{
    public class GetPeoplesByIdQuery : IRequest<People>
    {
        public int Id { get; set; }

        public class GetPeoplesByIdQueryHandler : IRequestHandler<GetPeoplesByIdQuery, People>
        {
            private readonly IApplicationDbContext _context;
            public GetPeoplesByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<People> Handle(GetPeoplesByIdQuery query, CancellationToken cancellationToken)
            {
                var People = _context.Peoples.Where(a => a.Id == query.Id).FirstOrDefault();
                if (People == null) return null;
                return People;
            }

        }
    }
}
