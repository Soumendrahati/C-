using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// Static Imports 
using static System.Math;
using static CSharpPractice.Util;


namespace CSharpPractice
{
    class Program
    {
        public ICollection<Double> grades { get; } = new List<Double>();
        static void Main(string[] args)
        {
            // StaticImports();

            // Console.WriteLine(UnitTestEmailEncoding());
            Console.ReadLine();
        }

        /// <summary>
        /// Static Imports C# 6.0
        /// </summary>
        public static void StaticImports()
        {
            int r = Math.Min(10, 11);
            Console.WriteLine(r);

            //// To Access the static method above " Static Imports" works
            //// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#using-static
            Console.WriteLine(Me("SH"));

            //// To Access the non static method you have to create object of the class
            Util util = new Util();
            Console.WriteLine(util.MeToo("SH"));

            Console.ReadLine();

            //// The static using directive also imports any nested types
            nested obj = new nested();
        }

        /// <summary>
        /// Auto-property initializers
        //// Auto-property initializers let you declare the initial value 
        //// for an auto-property as part of the property declaration.
        /// </summary>
        public static void AutoPropertyIntializer()
        {
           // grades = new List<Double> { 1.2d, 3.0d };
        }

        public static bool UnitTestEmailEncoding()
        {
            //string orderDate = DateTime.Now.ToShortDateString() as string; //1/31/2019
            DateTime[] dts = new DateTime[] {
                new DateTime(2019, 01, 01), new DateTime(2019, 01, 30), new DateTime(2019, 02, 01), new DateTime(2019, 02, 28),
                new DateTime(2019, 12, 01), new DateTime(2019, 12, 30), new DateTime(2019, 03, 01), new DateTime(2019, 03, 30),
                new DateTime(2019, 04, 01), new DateTime(2019, 04, 30), new DateTime(2019, 05, 01), new DateTime(2019, 05, 30),
                new DateTime(2019, 06, 01), new DateTime(2019, 06, 30), new DateTime(2019, 07, 01), new DateTime(2019, 07, 30),
                new DateTime(2019, 08, 01), new DateTime(2019, 08, 30), new DateTime(2019, 09, 01), new DateTime(2019, 09, 30),
               new DateTime(2019, 10, 01), new DateTime(2019, 10, 30), new DateTime(2019, 11, 01), new DateTime(2019, 11, 30)
            };
            int orderNumberN = 0070010655;

            foreach (var date in dts)
            {
                //string orderDate = DateTime.Now.ToString("MM/dd/yyyy") as string;
                string orderDate = date.ToString("MM/dd/yyyy") as string;
                orderNumberN = orderNumberN + 1; //0081027519
                string shipToZip = "34608";

                var orderSatusKey = Encoding.UTF8.GetBytes(String.Format("{0}{1}{2}{3}{4}", "00" + orderNumberN.ToString(), ":", shipToZip, ":", orderDate));
                var orderSatusEmailAuthKey = Convert.ToBase64String(orderSatusKey);
                Console.WriteLine("00" + orderNumberN.ToString() + ": " + orderSatusEmailAuthKey);
                if (orderSatusEmailAuthKey.Contains("="))
                {
                    return false;
                }
            }

            return true;
        }
}
}