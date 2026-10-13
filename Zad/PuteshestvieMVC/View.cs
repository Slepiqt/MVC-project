using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PuteshestvieMVC
{
    public class View
    {
        public double Cena { get; set; }
        public string Sezon { get; set; }

        public double EndPrice { get; set; }

        public string Destinaciq { get; set; }

        public string Prestoi { get; set; }

        public void Vkarvane()
        {
            Console.Write("Bujet, realno chislo v interval ot [10.00 - 5000.00]: ");
            Cena = double.Parse(Console.ReadLine());
            Console.Write("V koi sezon shte patuvash [summer ili zima]: ");
            Sezon = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"Somewhere in {Destinaciq}");
            Console.WriteLine($"{Prestoi} - {EndPrice:F2}");
        }
    }
}
