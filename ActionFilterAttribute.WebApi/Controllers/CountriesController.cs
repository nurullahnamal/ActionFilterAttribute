using ActionFilterAttribute.WebApi.ActionFilters;
using ActionFilterAttribute.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterAttribute.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AdvangeLogging]
    public class CountriesController : ControllerBase
    {
        private readonly CountryService countryService;

        public CountriesController(CountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]

        public ActionResult Get()
        {
            var countries = countryService.GetAllCountries();
            return Ok(countries);
        }
    }
}
