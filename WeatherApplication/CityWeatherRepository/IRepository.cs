using WeatherApplication.Models;

namespace WeatherApplication.CityWeatherRepository
{
    public interface IRepository
    {
        public IList<CityWeather> GetAllEntities();

        public CityWeather? GetByCode(string cityUniCode);
    }
}
