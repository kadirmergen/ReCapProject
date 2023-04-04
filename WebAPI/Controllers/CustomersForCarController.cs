using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersForCarController : ControllerBase
    {
        ICustomersForCarService _customersForCarService;

        public CustomersForCarController(ICustomersForCarService customersForCarService)
        {
            _customersForCarService = customersForCarService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customersForCarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CustomersForCar customersForCar)
        {
            var result = _customersForCarService.Delete(customersForCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(CustomersForCar customersForCar)
        {
            var result = _customersForCarService.Update(customersForCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int customerId)
        {
            var result = _customersForCarService.GetById(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        

        [HttpPost("add")]
        public IActionResult Add(CustomersForCar customersForCar)
        {
            var result = _customersForCarService.Add(customersForCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
