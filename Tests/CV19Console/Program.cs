using System;
using System.Net;
using System.Net.Http;

namespace CV19Console
{
    class Program
    {
        private const string data_url = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";

        static void Main(string[] args)
        {
            // из старых версий .NET Framework
            //var client = new WebClient();

            var client = new HttpClient();
            var response = client.GetAsync(data_url).Result;
            var csv_str = response.Content.ReadAsStringAsync().Result;
            Console.ReadLine();

        }
    }
}
