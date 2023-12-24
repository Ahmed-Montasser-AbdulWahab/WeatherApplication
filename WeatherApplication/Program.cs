using WeatherApplication.CityWeatherRepository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepository, Repository>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllers();


app.Run();
