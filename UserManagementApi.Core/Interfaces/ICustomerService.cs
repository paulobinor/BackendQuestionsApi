using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementApi.Core.Models;

namespace UserManagementApi.Core.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> Customers();
        Task<Customer> Customer(int Id);
        Task<List<Order>> Orders();
        Task<Customer> AddNewCustomer(Customer customer);
        Task<string> GetCustomerLoans(string CustomerNo);
    }
}
