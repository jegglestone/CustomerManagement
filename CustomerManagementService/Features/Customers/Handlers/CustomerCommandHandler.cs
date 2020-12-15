using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerManagementService.Features.Customers.Models;
using CustomerManagementService.Model;
using MediatR;

namespace CustomerManagementService.Features.Customers.Handlers
{
    public class CustomerCommandHandler : IRequestHandler<CustomerCreateCommand, Customer>
    {
        public Task<Customer> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
