﻿using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;

namespace OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetCustomer(id);

            if (result is not null)
                return Ok(result);

            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result = _customerService.GetAllCustomers();

            if (result is not null) 
                return Ok(result);

            return BadRequest("No records found");
        }

        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok("Data inserted");
        }

        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Updation done");
        }

        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int Id)
        {
            _customerService.DeleteCustomer(Id);
            return Ok("Data Deleted");
        }
    }
}
