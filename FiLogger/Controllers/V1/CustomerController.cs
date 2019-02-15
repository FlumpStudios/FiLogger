using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FiLogger.Common.Models;
using FiLogger.Context.Data;
using CryptoLib;
using Microsoft.Extensions.Logging;

namespace FiLogger.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AP_ReplacementContext _context;
        private readonly ICryptoManager _cryptoManager;
        readonly ILogger<CustomerController> _logger;

        public CustomerController(AP_ReplacementContext context, ICryptoManager cryptoManager, ILogger<CustomerController> logger)
        {
            _logger = logger;
            _cryptoManager = cryptoManager;
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDetails>>> GetCustomerDetails()
        {
            return await _context.CustomerDetails.ToListAsync();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetails>> GetCustomerDetails(int id)
        {
            CustomerDetails customerDetails = await _context.CustomerDetails.FindAsync(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return customerDetails;
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerDetails(int id, CustomerDetails customerDetails)
        {
            if (id != customerDetails.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customerDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customer
        [HttpPost]
        public async Task<ActionResult<CustomerDetails>> PostCustomerDetails(CustomerDetails customerDetails)
        {
            _context.CustomerDetails.Add(customerDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerDetails", new { id = customerDetails.CustomerId }, customerDetails);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerDetails>> DeleteCustomerDetails(int id)
        {
            var customerDetails = await _context.CustomerDetails.FindAsync(id);
            if (customerDetails == null)
            {
                return NotFound();
            }

            _context.CustomerDetails.Remove(customerDetails);
            await _context.SaveChangesAsync();

            return customerDetails;
        }

        private bool CustomerDetailsExists(int id)
        {
            return _context.CustomerDetails.Any(e => e.CustomerId == id);
        }
    }
}
