using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FiLogger.Common.Models;
using FiLogger.Context.Data;

namespace FiLogger.API.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v2/[controller]")]
    [ApiController]
    public class CustomerControllerV2 : ControllerBase
    {
        private readonly AP_ReplacementContext _context;

        public CustomerControllerV2(AP_ReplacementContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDetails>>> GetCustomerDetails()
        {
            await _context.CustomerDetails.ToListAsync();
            throw new NotImplementedException("Version 2 of API is not live");
        }

    }
}
