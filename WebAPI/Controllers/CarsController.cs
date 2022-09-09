using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllDetailDto")]
        public IActionResult GetAllDetailDto()
        {
            var result = _carService.GetAllDetailDto();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
