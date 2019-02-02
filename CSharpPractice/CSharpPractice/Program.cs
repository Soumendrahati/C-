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
        static void Main(string[] args)
        {
            StaticImports();
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
    }
}