using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB_WS.entities
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public float SurfaceArea { get; set; }
        public long Population { get; set; }
        public Country() { }

        public Country(string code, string name, string continent, string region, float surfaceArea)
        {
            Code = code;
            Name = name;
            Continent = continent;
            Region = region;
            SurfaceArea = surfaceArea;
        }

        public override bool Equals(object obj)
        {
            Country country = obj as Country;
            return Code == country?.Code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}