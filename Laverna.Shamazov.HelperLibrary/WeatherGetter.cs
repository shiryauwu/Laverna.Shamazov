using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Laverna.Shamazov.HelperLibrary
{
    /// <summary>
    /// Получатель погоды.
    /// </summary>
    public static class WeatherGetter
    {
        /// <summary>
        /// Ключ API.
        /// </summary>
        private const string Key = "81d82e16b8085a7d65e60d6401116ec5";

        /// <summary>
        /// Получение температуры.
        /// </summary>
        /// <param name="cityName">Название города.</param>
        /// <param name="units">Единица измерения.</param>
        /// <param name="language">Язык.</param>
        /// <returns>Значение температуры.</returns>
        public static string GetTemperature(string cityName, string units, string language)
        {
            var client = new HttpClient();

            return 
                JObject.Parse(
                    JObject.Parse(
                        client
                        .GetStringAsync($"https://api.openweathermap.org/" +
                            $"data" +
                            $"/2.5/" +
                            $"weather?" +
                            $"q={cityName}" +
                            $"&APPID={Key}" +
                            $"&units={units}" +
                            $"&lang={language}")
                        .Result)
                        .GetValue("main")
                        .ToString())
                        .GetValue("temp")
                        .ToString();
        }

        /// <summary>
        /// Получение описания погоды.
        /// </summary>
        /// <param name="cityName">Название города.</param>
        /// <param name="units">Единица измерения.</param>
        /// <param name="language">Язык.</param>
        /// <returns>Описание погоды.</returns>
        public static string GetWeatherDescription(string cityName, string units, string language)
        {
            var client = new HttpClient();

            return 
                JObject.Parse(
                    JObject.Parse(
                        client
                        .GetStringAsync($"https://api.openweathermap.org/" +
                            $"data" +
                            $"/2.5/" +
                            $"weather?" +
                            $"q={cityName}" +
                            $"&APPID={Key}" +
                            $"&units={units}" +
                            $"&lang={language}")
                        .Result)
                        .GetValue("weather")[0]
                        .ToString())
                        .GetValue("description")
                        .ToString();
        }

        /// <summary>
        /// Получение скорости ветра в км/ч.
        /// </summary>
        /// <param name="cityName">Название города.</param>
        /// <param name="units">Единица измерения.</param>
        /// <param name="language">Язык.</param>
        /// <returns>Скорость ветра в км/ч.</returns>
        public static string GetWindSpeed(string cityName, string units, string language)
        {
            var client = new HttpClient();

            return
                JObject.Parse(
                    JObject.Parse(client.GetStringAsync($"https://api.openweathermap.org/" +
                            $"data" +
                            $"/2.5/" +
                            $"weather?" +
                            $"q={cityName}" +
                            $"&APPID={Key}" +
                            $"&units={units}" +
                            $"&lang={language}")
                        .Result)
                        .GetValue("wind")
                        .ToString())
                .GetValue("speed")
                .ToString();
        }
    }
}
