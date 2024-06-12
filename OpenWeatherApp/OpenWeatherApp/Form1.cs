using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Net.Security;

namespace OpenWeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here if needed
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string city = textCity.Text; // Get the city name from the text box
            GetGeocode(city); // Call the method to get geocode and weather data
        }

        // OpenWeather API key
        string APIKey = "9064b1e7693ea2c297ba7f3c8c90828b";

        // Method to get geocode (latitude and longitude) of a city
        void GetGeocode(string city)
        {
            // Ensure TLS 1.2 is used for secure communication
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (WebClient Web = new WebClient())
            {
                // Construct the geocode API URL with the city name and API key
                string geocodeUrl = string.Format("http://api.openweathermap.org/geo/1.0/direct?q={0}&limit=1&appid={1}", city, APIKey);
                var geocodeJson = Web.DownloadString(geocodeUrl); // Download the JSON response

                // Deserialize the JSON response to a list of GeocodeInfo objects
                List<GeocodeInfo> geocodeInfo = JsonConvert.DeserializeObject<List<GeocodeInfo>>(geocodeJson);

                // Check if any geocode information is returned
                if (geocodeInfo != null && geocodeInfo.Count > 0)
                {
                    double lat = geocodeInfo[0].Lat; // Get the latitude
                    double lon = geocodeInfo[0].Lon; // Get the longitude

                    // Call the method to get weather data using the latitude and longitude
                    GetWeather(lat, lon);
                }
                else
                {
                    // Show a message box if the city is not found
                    MessageBox.Show("City not found.");
                }
            }
        }

        // Method to get weather data using latitude and longitude
        void GetWeather(double lat, double lon)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (WebClient Web = new WebClient())
            {
                // Construct the weather API URL with the latitude, longitude, and API key
                string weatherUrl = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}", lat, lon, APIKey);
                var weatherJson = Web.DownloadString(weatherUrl); // Download the JSON response

                // Deserialize the JSON response to a WeatherInfo.Root object
                WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(weatherJson);

                Console.WriteLine(weatherJson); // Print the JSON response to the console for debugging

                // Update the UI with the weather information
                textCondition.Text = Info.Weather[0].Main;
                textDetails.Text = ToCapitalize(Info.Weather[0].Description);

                textSunset.Text = ConvertDateTime(Info.Sys.Sunset).ToString("HH:mm:ss");
                textSunrise.Text = ConvertDateTime(Info.Sys.Sunrise).ToString("HH:mm:ss");

                textWindspeed.Text = Info.Wind.Speed.ToString();
                textPressure.Text = Info.Main.Pressure.ToString();
            }
        }

        // Method to convert Unix time (seconds since epoch) to DateTime
        DateTime ConvertDateTime(long seconds)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); // Unix epoch start date
            return epoch.AddSeconds(seconds).ToLocalTime(); // Convert to local time
        }

        // Method to capitalize the first letter of each word in a string
        string ToCapitalize(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input);
        }
    }
}
