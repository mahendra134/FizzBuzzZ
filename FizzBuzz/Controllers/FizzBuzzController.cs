using FizzBuzz.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
           // _fizzBuzzDivisonService = fizzBuzzDivisonService;
        }

        [HttpGet]
        public ActionResult<string[]> GetFizzBuzzArray([FromQuery] string[] values)
        {
            try
            {
                var fizzBuzzArray = _fizzBuzzService.GetFizzBuzzArray(values);
                return Ok(fizzBuzzArray);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
