using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globalweather
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new ServiceReference1.GlobalWeatherSoapClient("GlobalWeatherSoap");
            
            //Console.WriteLine(client.GetCitiesByCountry("Sweden"));
            //Console.WriteLine(client.GetWeather("Uppsala","Sweden"));

            //Console.ReadLine();

            var client2 = new ServiceReference2.SweaWebServicePortTypeClient("SweaWebServiceHttpSoap12Endpoint");

            Console.WriteLine(client2.getAllCrossNames(ServiceReference2.LanguageType.sv));
            foreach (var item in client2.getAllCrossNames(ServiceReference2.LanguageType.sv))
            {
                Console.WriteLine(item.seriesname);
                Console.WriteLine(item.seriesdescription);
            }
            var namn = client2.getInterestAndExchangeGroupNames(ServiceReference2.LanguageType.sv);
            foreach (var item in namn)
             Console.WriteLine(item.groupid+ " " + item.groupidSpecified + " " +item.groupname); 
            {

            }

            //Console.WriteLine(client2.getInterestAndExchangeNames(ServiceReference2.LanguageType.sv));
            //foreach (var item in client2.getInterestAndExchangeNames(1,ServiceReference2.LanguageType.sv))
            //{
            //    Console.WriteLine(item.seriesname);
            //    Console.WriteLine(item.seriesdescription);
            //}
            String[] ccy = new string[2];
            ccy[0] = "SEKUSDPMI";
            ccy[1] = "SEKGBPPMI";
            

            Console.WriteLine();
            var wsResult = client2.getLatestInterestAndExchangeRates(ServiceReference2.LanguageType.sv, ccy);
            wsResult.dateto = DateTime.Today;
            wsResult.datefrom = DateTime.Today.AddMonths(-1);
            Console.WriteLine(wsResult.ToString());

            var res2 = client2.getAnnualAverageExchangeRates(2017, 2, ServiceReference2.LanguageType.sv);
            Console.WriteLine(res2.ToString());



            //Console.Write(wsResult.groups[0].series[0].resultrows[0].value.Value);
            
            //foreach (var item in client2.getLatestInterestAndExchangeRates(ServiceReference2.LanguageType.sv, ccy))
            //{
            //    Console.WriteLine(item.seriesname);
            //    Console.WriteLine(item.seriesdescription);
            //}

            Console.ReadLine();

        }
    }
}
