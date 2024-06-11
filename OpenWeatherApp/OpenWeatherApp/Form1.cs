﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
            Console.WriteLine("Clicking");
        }

        //string APIKey = "9064b1e7693ea2c297ba7f3c8c90828b";

        void GetWeather()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 ;

            using (WebClient Web = new WebClient())
            {
                //string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textCity.Text, APIKey);
                string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=9064b1e7693ea2c297ba7f3c8c90828b";
                var json = Web.DownloadString(url);

                WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                Console.WriteLine(json);

                // picIcon.ImageLocation = "http://openweathermap.org/img/w/" + Info.Weather[0].Icon + ".png";

                textCondition.Text = Info.Weather[0].Main;
                textDetails.Text = Info.Weather[0].Description;

                textSunset.Text = ConvertDateTime(Info.Sys.Sunset).ToString();
                textSunrise.Text = ConvertDateTime(Info.Sys.Sunrise).ToString();

                textWindspeed.Text = Info.Wind.Speed.ToString();
                textPressure.Text = Info.Main.Pressure.ToString();
            }
        }

        DateTime ConvertDateTime(long milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(milisec).ToLocalTime();
            return day;
        }
    }
}