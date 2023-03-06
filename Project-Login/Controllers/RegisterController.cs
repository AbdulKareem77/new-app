using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using DataAccess;

namespace Project_Login.Controllers
{
    [ApiController]
    [Route("CustomeRegister")]
    public class RegisterController : ControllerBase
    {
        IDbRegister es;
        public RegisterController(IDbRegister employeeService)
        {
            es = employeeService;
        }
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult  Add(Customer customer)
        {

             return Ok(es.AddCustomer(customer));
        }

        [HttpPost]
        [Route("LoginCustomer")]
        public IActionResult Login([FromForm]Customer customer)
        {
            return Ok(es.LoginCustomer(customer));
        }
        [HttpGet]
        [Route("Getproductsdata")]
        public IEnumerable<Product> GetProducts()
        {
            return  es.GetProducts();
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult FormDAta([FromRoute]int id,[FromForm]Customer customer)
        {
            return Ok("success");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Body([FromRoute] int id,[FromBody] Customer customer)
        {
            return Ok("success");
        }

    }
}
