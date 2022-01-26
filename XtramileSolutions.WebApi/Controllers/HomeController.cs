using XtramileSolutions.Application.Interfaces.Logics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace XtramileSolutions.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private ICountryLogics _countryLogics;
        private ICityLogics _cityLogics;
        private IGeneralLogics _generalLogics;

        public HomeController(ICountryLogics countryLogics, ICityLogics cityLogics, IGeneralLogics generalLogics)
        {
            _countryLogics = countryLogics;
            _cityLogics = cityLogics;
            _generalLogics = generalLogics;
        }

        [HttpGet]
        [Route("get-countries")]
        public IActionResult GetCountries()
        {
            var countryList = _countryLogics.GetAll();
            if (countryList == null)
            {
                return NotFound();
            }
            return Ok(countryList);
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

        [HttpGet]
        [Route("get-countryname-by-city")]
        public IActionResult GetCountryNameByCity(string cityName)
        {
            return Ok(_countryLogics.GetCountryNameByCity(cityName));
        }

        [HttpGet]
        [Route("get-fahrenheit-to-celcius")]
        public IActionResult ConvertFahrenheitToCelcius(double fahrenheit)
        {
            return Ok(_generalLogics.ConvertFahrenheitToCelcius(fahrenheit));
        }

    }
}
