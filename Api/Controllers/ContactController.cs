using Application.Invoices.Handlers;
using Application.Invoices.Queries;
using Application.Invoices.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpGet("{lon}")]
        public async Task<IActionResult> GetLocal(long lon)
        {
            return Ok(await Mediator.Send(new GetSistemQuery{ lon = lon }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> ContactDelete(int id)
        {

            return Ok(await Mediator.Send(new DeleteContactByIdCommand { Id = id }));



        }
        [HttpGet]
        public async Task<IList<PeopleVM>> GetPeoples()
        {
            return await Mediator.Send(new GetAnaQuery());
        }


       
        
    }


}





