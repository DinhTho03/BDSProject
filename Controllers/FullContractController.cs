using dotnet_rpg.Dtos;
using dotnet_rpg.IService;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FullContractController : ControllerBase
    {
        private readonly IFullContract _fullContract;

        public FullContractController(IFullContract fullContract) 
        {
            _fullContract = fullContract;
        }
        [HttpGet("GetFullContract")]
        public IActionResult Get()
        {
            return Ok(_fullContract.GetFull_Contracts());
        }

        [HttpPost("AddFullContract")]
        public IActionResult Add(FullContractDto contract)
        {
            return Ok(_fullContract.Add(contract));
        }
    }
}
