using FiLogger.Common.Models;
using FiLogger.Context.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiLogger.DataAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AP_ReplacementContext _context;        

        public CustomerRepository(AP_ReplacementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerDetails>> GetCustomerDetails() => await _context.CustomerDetails.ToListAsync();
        public async Task<CustomerDetails> GetCustomerDetails(int id) => await _context.CustomerDetails.FindAsync(id);
        public CustomerDetails AddCustomer(CustomerDetails customerDetails) => _context.CustomerDetails.Add(customerDetails).Entity;
        public void UpdateCustomer(CustomerDetails customerDetails) => _context.Entry(customerDetails).State = EntityState.Modified;
        public void DeleteVehicle(int id) => _context.CustomerDetails.Remove(_context.CustomerDetails.Find(id));
        public bool CustomerDetailsExists(int id) => _context.CustomerDocuments.ToList().Any(e => e.CustomerId == id);
        public void Save() => _context.SaveChanges();
        public async Task SaveAsync() => await _context.SaveChangesAsync();

        #region Desturctor       
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
