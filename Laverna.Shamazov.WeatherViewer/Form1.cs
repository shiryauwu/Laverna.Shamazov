using Laverna.Shamazov.HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laverna.Shamazov.WeatherViewer
{
    public partial class WeatherViewerForm : Form
    {
        public WeatherViewerForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Обработка нажатия на кнопку "Узнать погоду."
        /// </summary>
        /// <param name="sender">Отправитель.</param>
        /// <param name="e">Аргументы события.</param>
        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            var city = EnterCityTextBox.Text;

            if (String.IsNullOrEmpty(city)) 
            {
                MessageBox.Show("Ничего не введено!");
            }
            else
            {
                try
                {
                    TemperatureTextBox.Text = WeatherGetter.GetTemperature(city, "metric", "ru");
                    DescriptionTextBox.Text = WeatherGetter.GetWeatherDescription(city, "metric", "ru");
                    WindSpeedTextBox.Text = WeatherGetter.GetWindSpeed(city, "metric", "ru");
                }
                catch(Exception) 
                {
                    MessageBox.Show("Произошла ошибка! Возможно вы ввели ошибочные данные.");
                }
            }
        }
    }
}
