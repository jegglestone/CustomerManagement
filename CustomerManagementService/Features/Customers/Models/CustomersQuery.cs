using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagementService.Model;

namespace CustomerManagementService.Features.Customers.Models
{
    public class CustomersQuery : IRequest<List<Customer>>
    {
        public bool? IsActive { get; set; }
    }
}
