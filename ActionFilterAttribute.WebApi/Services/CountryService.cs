using ActionFilterAttribute.WebApi.Models;

namespace ActionFilterAttribute.WebApi.Services
{
    public class CountryService
    {

        public IEnumerable<Country> GetAllCountries()
        {
            return new List<Country>()
            {
                new Country(){Name="Türkiye"},
                new Country(){Name="Ukranya"},
                new Country(){Name="danimarka"},
                new Country(){Name="Avusturya"},
                new Country(){Name="Avusturalya"},
                new Country(){Name="Yuanistan"},
                new Country(){Name="Canada"},
                new Country(){Name="mexico"},
                new Country(){Name="Finlandiya"}


            };
        }
    }
}
