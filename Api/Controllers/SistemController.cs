using Application.Invoices.Handlers;
using Application.Invoices.Queries;
using Application.Invoices.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// For 

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemController : ControllerBase
    {
        private IMediator _mediator;
        private long lon;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpGet("{lon}")]
        public async Task<IActionResult> GetById(long lon)
        {
            return Ok(await Mediator.Send(new GetSistemQuery { lon = lon }));
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    return Ok(await Mediator.Send(new GetSistemMessage()));
        //}

   
    }
}


