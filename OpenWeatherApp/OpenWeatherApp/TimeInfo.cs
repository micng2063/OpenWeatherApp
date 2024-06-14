using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp
{
    public class TimeInfo
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string CityName { get; set; }
        public string ZoneName { get; set; }
        public string Abbreviation { get; set; }
        public int GMTOffset { get; set; }
        public string DST { get; set; }
        public string NextAbbreviation { get; set; }
        public long Timestamp { get; set; }
        public string Formatted { get; set; }
    }
}
