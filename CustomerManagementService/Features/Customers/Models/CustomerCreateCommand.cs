using System.Collections.Generic;
using CustomerManagementService.Model;
using MediatR;

namespace CustomerManagementService.Features.Customers.Models
{
    public class CustomerCreateCommand : IRequest<Customer>
    {
        public string Title { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNo { get; set; }

        public bool IsActive { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
