using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomerManagementService.Features.Customers.Models;
using CustomerManagementService.Model;
using MediatR;

namespace CustomerManagementService.Features.Customers.Handlers
{
    public class CustomerQueryHandler : IRequestHandler<CustomersQuery, List<Customer>>
    {
        public Task<List<Customer>> Handle(CustomersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
