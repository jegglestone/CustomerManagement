using System.Collections.Generic;
using CustomerManagementService.Model;

namespace CustomerManagementService.Data.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}