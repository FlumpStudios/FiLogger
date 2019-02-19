using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FiLogger.Context.Data;
using FiLogger.Common.Settings;
using Microsoft.Extensions.Options;
using AutoMapper;
using FiLogger.Service.Contracts;
using vm = FiLogger.API.DataContracts.Customer;
using dm = FiLogger.Common.Models;

namespace FiLogger.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AP_ReplacementContext _context;
        private readonly IMapper _mapper;
        private readonly ICustomerService _service;

        public CustomerController(AP_ReplacementContext context, 
             IOptions<AppSettings> appSettings,
             IMapper mapper,
             ICustomerService service)
        {
            _context = context;
            _mapper = mapper;
            _service = service;
        }
        

        /// <summary>
        /// Return full list of customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<vm.CustomerDetails>>> Get()
        {
            return _mapper.Map<IEnumerable<vm.CustomerDetails>>(await _service.GetCustomerDetails()).ToList();
        }

        /// <summary>
        /// Get customer via their ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<vm.CustomerDetails>> Get(int id)
        {
            return _mapper.Map<vm.CustomerDetails>(await _service.GetCustomerDetails(id)); 
        }       

        /// <summary>
        /// Create a new customer
        /// </summary>
        /// <param name="customerDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<vm.CustomerDetails>> Post(vm.CustomerDetails customerDetails)
        {          
            var createdDetails = _mapper.Map<vm.CustomerDetails>(await _service.CreateCustomerDetails(Mapper.Map<dm.CustomerDetails>(customerDetails)));            
            return CreatedAtAction("Get", new { id = createdDetails.CustomerId }, createdDetails);
        }

        /// <summary>
        /// Update a customer record
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerDetails"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, vm.CustomerDetails customerDetails)
        {
            var updateSuccessful = await _service.UpdateCustomerDetails(id, Mapper.Map<dm.CustomerDetails>(customerDetails));
            if (updateSuccessful) return Ok(string.Format("Customer with ID of {0} was successfully updated", id));
            return BadRequest();
        }

        /// <summary>
        /// Delete a customer record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteSuccessful = await _service.DeleteCustomerDetails(id);
            if (deleteSuccessful) return Ok(string.Format("Customer with ID of {0} was successfully deleted",id));
            return BadRequest();             
        }
        
    }
}
