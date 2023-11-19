using Microsoft.AspNetCore.Mvc;

namespace DapperTrial.Controllers
{
   
    {
        using Microsoft.AspNetCore.Mvc;

public class CityController : Controller
    {
        private readonly DapperContext _dapperContext;

        public CityController(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public IActionResult Index(int minPopulation, int maxPopulation)
        {
            var cities = _dapperContext.GetCitiesByPopulationRange(minPopulation, maxPopulation);
            return View(cities);
        }

        // Add other actions for optional features
    }

}
}
