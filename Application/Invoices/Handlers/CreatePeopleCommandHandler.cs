using Application.Common.Interfaces;
using Application.Invoices.Commands;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Invoices.Handlers
{
    public class CreatePeopleCommandHandler : IRequestHandler<CreatePeopleCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreatePeopleCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreatePeopleCommand request, CancellationToken cancellationToken)
        {
            var entity = new People
            {
                LastName = request.LastName,
                Name = request.Name,
                Company = request.Company,
                ReportTime = request.ReportTime,
                Contacts = request.Contacts.Select(i => new Contact
                {
                    Phone = i.Phone,
                    Addrees = i.Addrees,
                    Email = i.Email,
                    Location = i.Location,
                    Info = i.Info
                }).ToList()
            };
            _context.Peoples.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
