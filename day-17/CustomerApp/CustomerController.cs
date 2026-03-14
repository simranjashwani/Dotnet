// using Microsoft.AspNetCore.Mvc;

// [ApiController]
// [Route("api/v1/[controller]")]

// public class CustomerController : ControllerBase
// {
//     //model binding 
//     // model validation
//     [HttpGet("{auth:binary}")]
//     public IActionResult GetAllCustomersByAuth([FromHeader]byte []auth)
//     {
//         return Ok(new List<string> {"Alice","Bob","charlie"});
//     }
// [HttpGet]
//     public IActionResult GetAllCustomers()
//     {
//         return Ok(new List<string> {"Alice","Bob","charlie"});
//     }// /api/v1/customer?id=1

//  [HttpGet("{id:int}")]
//     public IActionResult GetCustomerById(int id)
//     {
//         return Ok("Alice");
//     }

// }
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class CustomerController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllCustomers()
    {
        return Ok(new List<string> { "Alice", "Bob", "Charlie" });
    }

    [HttpGet("{id:int}")]
    public IActionResult GetCustomerById(int id)
    {
        return Ok("Alice");
    }
}