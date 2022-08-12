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
        public IActionResult Login(Customer customer)
        {
            return Ok(es.LoginCustomer(customer));
        }
        [HttpGet]
        [Route("Getproductsdata")]
        public IEnumerable<Product> GetProducts()
        {
            return  es.GetProducts();
        }
    }
}
