using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Application.Invoices.ViewModels;

namespace Application.Invoices.Queries
{

    public class GetAnaQuery : IRequest<IList<PeopleVM>>
    {
        public string User { get; set; }
    }
   
}
