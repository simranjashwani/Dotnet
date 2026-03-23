using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(new[] { "Simran", "Rahul", "Ankit" });
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] CustomerRequest request)
        {
            return Ok($"Customer {request.Name} created");
        }
    }

    public class CustomerRequest
    {
        public string Name { get; set; }
    }
}