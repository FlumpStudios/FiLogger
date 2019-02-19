using System.Collections.Generic;
using System.Threading.Tasks;
using FiLogger.Common.Models;

namespace FiLogger.Service.Contracts
{
    public interface ICustomerService
    {
        Task<CustomerDetails> CreateCustomerDetails(CustomerDetails customerDetails);
        Task<bool> DeleteCustomerDetails(int id);
        Task<IEnumerable<CustomerDetails>> GetCustomerDetails();
        Task<CustomerDetails> GetCustomerDetails(int id);
        Task<bool> UpdateCustomerDetails(int id, CustomerDetails customerDetails);
    }
}