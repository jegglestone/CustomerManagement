using System.Threading;
using System.Threading.Tasks;
using CustomerManagementService.Data.Repositories;
using CustomerManagementService.Features.Customers.Models;
using CustomerManagementService.Model;
using MediatR;

namespace CustomerManagementService.Features.Customers.Handlers
{
    public class CustomerCommandHandler : IRequestHandler<CustomerCreateCommand, Customer>
    {
        private readonly ICustomerRepository _repository;

        public CustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddCustomerAsync(new Customer()
            {
                Title = request.Title,
                Forename = request.Forename,
                Surname = request.Surname,
                EmailAddress = request.EmailAddress,
                MobileNo = request.MobileNo,
                IsActive = request.IsActive,
                Addresses = request.Addresses
            });
        }
    }
}
