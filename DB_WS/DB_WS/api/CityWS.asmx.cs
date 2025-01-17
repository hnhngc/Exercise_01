using DB_WS.DB;
using DB_WS.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DB_WS.api
{
    /// <summary>
    /// Summary description for CityWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CityWS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<City> getAllCities()
        {
            CityRepository countryRepository = new CityRepository();
            return countryRepository.getAllCities();
        }
        [WebMethod]
        public Country GetCountryByCode(string countryCode)
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetCountryByCode(countryCode);
        }

        [WebMethod]
        public City GetCityByName(string cityName)
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetCityByName(cityName);
        }

        [WebMethod]
        public List<City> GetCitiesByCountry(string countryCode)
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetCitiesByCountry(countryCode);
        }

        [WebMethod]
        public List<Country> GetCountriesByPopulation(long populationThreshold)
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.GetCountriesByPopulation(populationThreshold);
        }
    }
}
