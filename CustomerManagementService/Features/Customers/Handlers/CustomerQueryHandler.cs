﻿using CustomerManagementService.Data.Repositories;
using CustomerManagementService.Features.Customers.Models;

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
            var customers = request.IsActive == null
                ? await _repository.GetCustomersAsync()
                : await _repository.GetCustomersAsync(c => c.IsActive == (bool) request.IsActive);

            return customers;
        }
    }
}
