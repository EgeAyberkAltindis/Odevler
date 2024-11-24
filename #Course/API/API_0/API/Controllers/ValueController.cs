using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase                
    {
        static List<string> cities = new List<string>
        {
            "İstanbul", "İzmir", "Eskişehir","Ankara","Adana"
        };
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(cities);
        }
        [HttpPost]
        public IActionResult AddCitty(string item)
        {
           cities.Add(item);
           return Ok(cities);
        }
        [HttpPut]
        public IActionResult UpdateCity ( int index, string newValue)
        {
            cities[index] = newValue;
            return Ok("sehir Güncellendi");
        }
        [HttpDelete]
        public IActionResult DeleteCity ( int index )
        {
            cities.Remove(cities[index]);
            return Ok("şehir güncellendi");
        }
    }
}
