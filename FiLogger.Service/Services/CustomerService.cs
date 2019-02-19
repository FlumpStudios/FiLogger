using CryptoLib;
using FiLogger.Common.Models;
using FiLogger.DataAccess.Repositories;
using FiLogger.Service.Contracts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiLogger.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICryptoManager _cryptoManager;
        private readonly ILogger<CustomerService> _logger;
         
        public CustomerService(ICustomerRepository customerRepository, ICryptoManager cryptoManager, ILogger<CustomerService> logger)
        {
            _customerRepository = customerRepository;
            _cryptoManager = cryptoManager;
            _logger = logger;
        }

         public async Task<IEnumerable<CustomerDetails>> GetCustomerDetails()
         {
            IEnumerable<CustomerDetails> customer = null;

            try
            {
                customer = await _customerRepository.GetCustomerDetails();
            }
            catch (Exception e)
            {
                _logger.LogError("Error Retrieving list of CustomerDetails", e);
                throw;
            }

            return customer;            
         }

        public async Task<CustomerDetails> GetCustomerDetails(int id)
        {
            CustomerDetails customerDetails = null;

            try
            {
                customerDetails = await _customerRepository.GetCustomerDetails(id);
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format("Could not retrieve customer with the ID of {0}",id), e);
            }

            return customerDetails;
        }

        public async Task<bool> UpdateCustomerDetails(int id, CustomerDetails customerDetails)
        {
            if (id != customerDetails.CustomerId)
            {
                _logger.LogInformation(string.Format("ID mismatch between provided ID({0}) and the ID contained in Customer Record ({1})",id,customerDetails.CustomerId));
                return false;
            }

            _customerRepository.UpdateCustomer(customerDetails);

            try
            {
                await _customerRepository.SaveAsync();
            }
            catch (Exception e)
            {
                if (!_customerRepository.CustomerDetailsExists(id))
                {
                    _logger.LogInformation(string.Format("Could not find customer with id {0} when trying to update details", id), e);
                    return false;                         
                }
                else
                {
                    _logger.LogError(string.Format("Error attempting to update customerDetails with id {0}", id), e);
                    throw;
                }
            }

            return true;
        }

        public async Task<CustomerDetails> CreateCustomerDetails(CustomerDetails customerDetails)
        {
            CustomerDetails returnedCustomerDetails = null;

            try
            {
                returnedCustomerDetails = _customerRepository.AddCustomer(customerDetails);
                await _customerRepository.SaveAsync();
            }
            catch(Exception e) {
                _logger.LogError("Error creating new customer", e);
                throw;
            }

            return returnedCustomerDetails;
        }

        public async Task<bool> DeleteCustomerDetails(int id)
        {            
            if (!_customerRepository.CustomerDetailsExists(id))
            {
                _logger.LogInformation(string.Format("Could not find Customer with Id {0} when attempting to delete", id));
                return false;
            }

            try
            {
                _customerRepository.DeleteVehicle(id);
                await _customerRepository.SaveAsync();
            }

            catch(Exception e)
            {
                _logger.LogError(string.Format("Error attempting to delete customer with the id {0}", id), e);
                 throw;
            }

            return true;
        }
    }
}
