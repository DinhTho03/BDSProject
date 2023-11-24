using dotnet_rpg.Data;
using dotnet_rpg.Dtos;
using dotnet_rpg.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IProperty _property;

        public PropertyController(IProperty property) 
        {
            _property = property;
        }
        [HttpGet("GetAllProperty")]
        public IActionResult GetAll()
        {
            var data = _property.GetAll();
            return Ok(data);
        }
        [HttpPost("AddProperty")]
        public IActionResult Add(PropertyDto propertyDto)
        {
            var data = _property.Add(propertyDto);
            return Ok(data);
        }
    }
}
