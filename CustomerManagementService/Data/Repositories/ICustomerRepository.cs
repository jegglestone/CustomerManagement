using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManagementService.Model;

namespace CustomerManagementService.Data.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
    }
}