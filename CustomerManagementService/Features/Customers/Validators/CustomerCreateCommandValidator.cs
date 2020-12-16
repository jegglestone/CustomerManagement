using CustomerManagementService.Data.Repositories;
using CustomerManagementService.Features.Customers.Models;
using FluentValidation;
using System.Linq;

namespace CustomerManagementService.Features.Customers.Validators
{
    public class CustomerCreateCommandValidator
    : AbstractValidator<CustomerCreateCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerCreateCommandValidator(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

            // customer can only exist once
            RuleFor(x => x.Forename)
                .Must(NotExist)
                .WithErrorCode("CustomerAlreadyExists")
                .WithMessage("A customer with this name already exists");

        }

        private bool NotExist(CustomerCreateCommand command, string forename)
        {
            var customers = _customerRepository.GetCustomersAsync().Result;

            return !customers.Any(
                y => y.Forename == forename 
                     && y.Surname == command.Surname 
                     && y.Title == command.Title);
        }
    }
}
