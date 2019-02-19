using System.Collections.Generic;
using System.Threading.Tasks;
using FiLogger.Common.Models;

namespace FiLogger.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        CustomerDetails AddCustomer(CustomerDetails customerDetails);
        bool CustomerDetailsExists(int id);
        void DeleteVehicle(int id);
        void Dispose();
        Task<IEnumerable<CustomerDetails>> GetCustomerDetails();
        Task<CustomerDetails> GetCustomerDetails(int id);
        void Save();
        Task SaveAsync();
        void UpdateCustomer(CustomerDetails customerDetails);
    }
}