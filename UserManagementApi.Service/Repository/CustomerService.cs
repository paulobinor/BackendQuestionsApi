using GTB.TRMS.WS;
using System.Net.Http;
using UserManagementApi.Core.Interfaces;
using UserManagementApi.Core.Models;

namespace UserManagementApi.Service.Repository
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerServiceDbRepo _customerServiceRepo;
        private readonly IHttpClientFactory _httpClientFactory;

        public CustomerService(ICustomerServiceDbRepo customerServiceRepo, IHttpClientFactory httpClientFactory)
        {
            _customerServiceRepo = customerServiceRepo;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Customer>> Customers()
        {
            return await _customerServiceRepo.Customers();
        }
        public async Task<Customer> Customer(int Id)
        {
            return await _customerServiceRepo.Customer(Id);
        }
        public async Task<List<Order>> Orders()
        {
            return await _customerServiceRepo.Orders();
        }
        public async Task<Customer> AddNewCustomer(Customer customer)
        {
            var newCustomer = await _customerServiceRepo.AddNewCustomer(customer);
            return newCustomer;
        }

        public async Task<string> GetCustomerLoans(string CustomerNo)
        {
            try
            {
                string url = $"{ConfigSettings.AppSettings.LoanServiceUrl}{CustomerNo}";

                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);

                using (var client = _httpClientFactory.CreateClient())
                {
                    var res = await client.SendAsync(httpRequestMessage);
                    if (res == null)
                    {
                        return string.Empty;
                    }
                    if (res.IsSuccessStatusCode)
                    {
                        var strResp = await res.Content.ReadAsStringAsync();
                        return strResp;
                    }
                    return string.Empty;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}