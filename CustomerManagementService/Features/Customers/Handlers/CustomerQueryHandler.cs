using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomerManagementService.Data.Repositories;
using CustomerManagementService.Features.Customers.Models;
using CustomerManagementService.Model;
using MediatR;

namespace CustomerManagementService.Features.Customers.Handlers
{
    public class CustomerQueryHandler : IRequestHandler<CustomersQuery, List<Customer>>
    {
        private readonly ICustomerRepository _repository;

        public CustomerQueryHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> Handle(CustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetCustomers();

            return customers;
        }
    }
}
