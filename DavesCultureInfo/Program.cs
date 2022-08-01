using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesCultureInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DCultureInfo dCultureInfo = new DCultureInfo("en-US");
            foreach (var prop in dCultureInfo.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(string[]))
                {
                    Console.WriteLine(prop.Name);
                    Console.WriteLine(string.Join(", ", (string[])prop.GetValue(dCultureInfo)));
                }
                else
                {
                    Console.WriteLine(prop.Name + ": " + prop.GetValue(dCultureInfo));
                }
                

            }
            Console.ReadKey();


        }
    }
}
