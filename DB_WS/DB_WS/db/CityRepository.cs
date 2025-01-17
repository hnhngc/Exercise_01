using DB_WS.entities;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DB_WS.DB
{
    public class CityRepository
    {
        private MySqlConnection connection;
        public CityRepository()
        {
            connection = ConnectDB.getInstance();
        }

        public List<City> getAllCities()
        {
            connection.Open();
            string sql = "select * from city";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<City> cities = new List<City>();
            while (rdr.Read())
            {
                City city = new City(
                    int.Parse(rdr[0].ToString()),
                        rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
                        int.Parse(rdr[4].ToString())
                    );
                cities.Add(city);
            }
            connection.Close();
            return cities;
        }
        // Get country by country code
        public Country GetCountryByCode(string countryCode)
        {
            connection.Open();
            string sql = "SELECT * FROM country WHERE Code = @Code";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Code", countryCode);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Country country = null;
            if (rdr.Read())
            {
                country = new Country(
                    rdr["Code"].ToString(),
                    rdr["Name"].ToString(),
                    rdr["Continent"].ToString(),
                    rdr["Region"].ToString(),
                    float.Parse(rdr["SurfaceArea"].ToString())
                );
            }
            connection.Close();
            return country;
        }

        // Get city by name
        public City GetCityByName(string cityName)
        {
            connection.Open();
            string sql = "SELECT * FROM city WHERE Name = @Name";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Name", cityName);
            MySqlDataReader rdr = cmd.ExecuteReader();

            City city = null;
            if (rdr.Read())
            {
                city = new City(
                    int.Parse(rdr["ID"].ToString()),
                    rdr["Name"].ToString(),
                    rdr["CountryCode"].ToString(),
                    rdr["District"].ToString(),
                    int.Parse(rdr["Population"].ToString())
                );
            }
            connection.Close();
            return city;
        }

        // Get all cities of a specific country
        public List<City> GetCitiesByCountry(string countryCode)
        {
            connection.Open();
            string sql = "SELECT * FROM city WHERE CountryCode = @CountryCode";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@CountryCode", countryCode);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<City> cities = new List<City>();
            while (rdr.Read())
            {
                City city = new City(
                    int.Parse(rdr["ID"].ToString()),
                    rdr["Name"].ToString(),
                    rdr["CountryCode"].ToString(),
                    rdr["District"].ToString(),
                    int.Parse(rdr["Population"].ToString())
                );
                cities.Add(city);
            }
            connection.Close();
            return cities;
        }

        // Other service: Get countries with population above a threshold
        public List<Country> GetCountriesByPopulation(long populationThreshold)
        {
            connection.Open();
            string sql = "SELECT * FROM country WHERE Population > @Population";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Population", populationThreshold);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Country> countries = new List<Country>();
            while (rdr.Read())
            {
                Country country = new Country(
                    rdr["Code"].ToString(),
                    rdr["Name"].ToString(),
                    rdr["Continent"].ToString(),
                    rdr["Region"].ToString(),
                    float.Parse(rdr["SurfaceArea"].ToString())
                );
                countries.Add(country);
            }
            connection.Close();
            return countries;
        }
    }
}