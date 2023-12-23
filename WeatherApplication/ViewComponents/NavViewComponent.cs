using Microsoft.AspNetCore.Mvc;

namespace WeatherApplication.ViewComponents
{
    [ViewComponent]
    public class NavViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            return View(model:name);
        }
    }
}
