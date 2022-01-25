using XtramileSolutions.Application.Interfaces.Logics;
using Microsoft.AspNetCore.Mvc;

namespace XtramileSolutions.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private ICountryLogics _countryLogics;
        private ICityLogics _cityLogics;

        public HomeController(ICountryLogics countryLogics, ICityLogics cityLogics)
        {
            _countryLogics = countryLogics;
            _cityLogics = cityLogics;
        }

        [HttpGet]
        [Route("get-countries")]
        public IActionResult GetCountries()
        {
            return Ok(_countryLogics.GetAll());
        }

        [HttpGet]
        [Route("get-cities")]
        public IActionResult GetCities()
        {
            return Ok(_cityLogics.GetAll());
        }

        [HttpGet]
        [Route("get-cities-by-country")]
        public IActionResult GetCitiesByCountry(string countryName)
        {
            return Ok(_cityLogics.GetCitiesByCountryCode(countryName));
        }

    }
}
