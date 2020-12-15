using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CustomerManagementService.Features.Customers.Models;
using CustomerManagementService.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerManagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IMediator _mediator;

        public CustomerController(
            ILogger<CustomerController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


        [HttpGet("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Customer>))]
        public async Task<IActionResult> All([FromQuery] CustomersQuery query)
        {
            var model = await _mediator.Send(query);

            return new ObjectResult(model)
            {
                StatusCode = (int)HttpStatusCode.OK
            };
        }
    }
}
