using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var client2 = new ServiceReference1.CurrencyConvertorSoapClient("CurrencyConvertorSoap12");

            var res = client2.ConversionRate(ServiceReference1.Currency.USD, ServiceReference1.Currency.SEK);
            Console.WriteLine(res.ToString());
            var res2 = client2.ConversionRate(ServiceReference1.Currency.EUR, ServiceReference1.Currency.SEK);
            Console.WriteLine(res2.ToString());
            var res3 = client2.ConversionRate(ServiceReference1.Currency.EUR, ServiceReference1.Currency.USD);
            Console.WriteLine(res3.ToString());
            Console.ReadLine();
        }
    }
}
