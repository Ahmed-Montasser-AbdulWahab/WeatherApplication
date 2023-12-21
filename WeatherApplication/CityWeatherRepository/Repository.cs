using WeatherApplication.Models;

namespace WeatherApplication.CityWeatherRepository
{
    public class Repository : IRepository
    {
        private IList<CityWeather> cities = new List<CityWeather>()
        {
            new CityWeather()
            {
                CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  TemperatureFahrenheit = 33
            },
            new CityWeather(){
                CityUniqueCode = "NYC", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60
            },
            new CityWeather(){
                CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82
            }

        };

        public IList<CityWeather> GetAllEntities()
        {
            return cities;
        }

        public CityWeather? GetByCode(string cityUniCode)
        {
            return cities.Where(e => e.CityUniqueCode == cityUniCode).FirstOrDefault();
        }
    }
}
