using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreAPI.Controllers
{
   // [EnableCors()]
    [Route("api/devesh/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDbContext _dbContext = new CustomerDbContext();
        public ActionResult<string> Get(){
            return "Devesh Sharma";
        }

        [Route("GetAll")]
         public ActionResult GetAll(){
             var CustomerList = _dbContext.Customers;
           /* var AllCustomer = new List<Customer> {
                new Customer() {Id = 1, Name = "Devesh"},
                new Customer() {Id = 2, Name = "Sharma"}
            }; */
            return Ok(CustomerList);
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult AddCustomer([FromBody]Customer _customer)
        {
            if (_customer != null)
            {
                _dbContext.Customers.Add(_customer);
                _dbContext.SaveChanges();
                return Ok("Customer Added.");
            }
            else
            {
                return BadRequest("Invalid Customer Object.");
            }

        }
    }
}