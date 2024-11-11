using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Core.Interfaces;
using UserManagementApi.Core.Models;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using UserManagementApi.Service.Repository;
using UserManagementApi.Service.Validators;
[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Admin, Users")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
        //_emailService = emailService;
       // _backgroundJobClient = backgroundJobClient;
    }

    [HttpGet("Customers")]    
    public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
    {
        try
        {
            var customers = await _customerService.Customers();
            return Ok(customers);
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("Orders")]
    public async Task<ActionResult<Order>> GetOrders()
    {
        try
        {
            return Ok(await _customerService.Orders());
        }
        catch (Exception)
        {
            throw;
        }
    }


    [HttpPost("Customers/Add")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> AddCustomer(Customer customer)
    {
        try
        {
            var validationResult = new AddNewCustomerValidator().Validate(customer);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }
            var newCustomer = await _customerService.AddNewCustomer(customer);
            return  StatusCode(200, newCustomer);
        }
        catch (Exception)
        {
            return StatusCode(500, new {responsecode = "500", Responsedescription = "We encountered an error! please try again later or contact support"});

          //  throw;
        }
    }

    [HttpGet("Customers/Loans/Get/{CustomerNo}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> GetCustomerLoans([FromRoute] string CustomerNo)
    {
        try
        {
            var validationResult = new GetCustomerLoansValidator().Validate(CustomerNo);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }

            var customerLoans = await _customerService.GetCustomerLoans(CustomerNo);
            if (string.IsNullOrEmpty(customerLoans))
            {
                return NotFound();
            }
            
            return  Ok(JsonNode.Parse(customerLoans).AsObject());
        }
        catch (Exception)
        {
            return StatusCode(500, new { responsecode = "500", Responsedescription = "We encountered an error! please try again later or contact support" });
            //throw;
        }
    }
}
