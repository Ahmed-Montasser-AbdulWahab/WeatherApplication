using Microsoft.AspNetCore.Mvc;
using WeatherApplication.CityWeatherRepository;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    [Controller]
    public class WeatherController : Controller
    {
        private readonly IRepository _repository = new Repository();
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            IList<CityWeather> cities = _repository.GetAllEntities();

            if (cities is null || cities.Count == 0)
            {
                ViewBag.Title = "Not Found | 404";
                return View("Not_Found");
            }
            ViewBag.Title = "All Cities";
            return View(cities);
        }

        [HttpGet]
        [Route("weather/{cityCode}")]
        public IActionResult Details(string cityCode)
        {
            CityWeather? cityWeather = _repository.GetByCode(cityCode);

            if(cityWeather == null)
            {
                ViewBag.Title = "Not Found | 404";
                return View("Not_Found");
            }
            ViewBag.Title = $"{cityWeather.CityName} Details";
            return View(cityWeather);
        }

    }
}
