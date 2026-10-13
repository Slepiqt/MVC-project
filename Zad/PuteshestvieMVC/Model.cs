using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuteshestvieMVC
{
    public class Model
    {
		private double cena;

		public double Cena
		{
			get { return cena; }
			set {cena = value;
				
				}
		}

		private string sezon;

		public string Sezon		
		{
			get { return sezon; }
	        set { sezon = value;
				
			}
		}
        private double fullprice;
		public double FullPrice { get {return fullprice; } set {fullprice = value; } }
        private string placetogo;
		public string PlaceToGo { get { return placetogo; } set { placetogo = value; } }
        private string sleepplace;
		public string SleepPlace { get {return sleepplace; } set {sleepplace = value; } }
		public double PriceGiver()
		{
		  if(Cena <= 100.00)
	      {
				if(Sezon == "summer")
				{
					 FullPrice = Cena * 30 / 100;					
                }
				else
				{
					 FullPrice = Cena * 70 / 100;               
                }
		  }
          else if (Cena <= 1000.00)
          {
                if (Sezon == "summer")
                {
                    FullPrice = Cena * 40 / 100;
                }
                else
                {
                    FullPrice = Cena * 80 / 100;
                }
          }
          else if (Cena > 1000.00)
          {
                if (Sezon == "summer")
                {
                    FullPrice = Cena * 90 / 100;
                }
                else
                {
                    FullPrice = Cena * 90 / 100;
                }
          }


          return FullPrice;
			
		}
		public string SleepPlaceGiver()
		{
            if (Cena <= 100.00)
            {
                if (Sezon == "summer")
                {
                    SleepPlace = "Camp";
                }
                else
                {
                    SleepPlace = "Hotel";
                }
            }
            if (Cena >  100.00 && Cena <= 1000.00)
            {
                if (Sezon == "summer")
                {
                    SleepPlace = "Camp";
                }
                else
                {
                    SleepPlace = "Hotel";
                }
            }
            if (Cena > 1000.00)
            {
                if (Sezon == "summer")
                {
                    SleepPlace = "Hotel";
                }
                else
                {
                    SleepPlace = "Hotel";
                }
            }
            return SleepPlace;
        }
        public string PlaceGiver()
        {
            if(Cena <= 100.00)
            {
                PlaceToGo = "Bulgaria";
            }
            if(Cena >100.00 && Cena <= 1000.00)
            {
                PlaceToGo = "Balkanite";
            }
            if(Cena > 1000.00)
            {
                PlaceToGo = "Evropa";
            }
            return PlaceToGo;
            
        }
	}
}
