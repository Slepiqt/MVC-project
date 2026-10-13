using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puteshestvie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Bujet, realno chislo v interval ot [10.00 - 5000.00]: ");
            double bujet = double.Parse(Console.ReadLine());
            Console.Write("V koi sezon shte patuvash [summer ili zima]: ");
            string sezon = Console.ReadLine();

            
            
            double EndPrice = 0;
            if (bujet <= 100.00)
            {
                if(sezon == "summer")
                {

                    EndPrice = bujet * 30 / 100 ;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {EndPrice:F2}");
                }
                else
                {
                    EndPrice = bujet * 70 / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Holet - {EndPrice:F2}");
                }
            }
            if (bujet <= 1000.00)
            {
                if (sezon == "summer")
                {

                    EndPrice = bujet * 40 / 100;
                    Console.WriteLine("Somewhere in Balkanite");
                    Console.WriteLine($"Camp - {EndPrice:F2}");
                }
                else 
                {
                    EndPrice = bujet * 80 / 100;
                    Console.WriteLine("Somewhere in Balkanite");
                    Console.WriteLine($"Holet - {EndPrice:F2}");
                }
            }
            if (bujet > 1000.00)
            {
                if (sezon == "summer")
                {

                    EndPrice = bujet * 90 / 100;
                    Console.WriteLine("Somewhere in Evropa");
                    Console.WriteLine($"Hotel - {EndPrice:F2}");
                }
                else
                {
                    EndPrice = bujet * 90 / 100;
                    Console.WriteLine("Somewhere in Evropa");
                    Console.WriteLine($"Holet - {EndPrice:F2}");
                }
            }

        }
    }
}
