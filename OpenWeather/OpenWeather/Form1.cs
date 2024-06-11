using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using OpenWeatherApp;

namespace OpenWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){ }

        private void label1_Click_1(object sender, EventArgs e){ }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e) { }

        private void label10_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        string APIKey = "9064b1e7693ea2c297ba7f3c8c90828b";
        
        void GetWeather()
        {
            using (WebClient Web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);

                var json = Web.DownloadString(url);

                WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                picIcon.ImageLocation = "http://openweathermap.org/img/w/" + Info.Weather[0].Icon + ".png";

                labCondition.Text = Info.Weather[0].Main;
                labDetails.Text = Info.Weather[0].Description;

                label6.Text = Info.Sys.Sunset.ToString();
                label7.Text = Info.Sys.Sunrise.ToString();

                label9.Text = Info.Wind.Speed.ToString();
                label8.Text = Info.Main.Pressure.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
