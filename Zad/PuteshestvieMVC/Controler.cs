using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuteshestvieMVC
{
    

     public class Controler
     {
       Model model = new Model();
        View view = new View();

        public void Start()
        {
            view.Vkarvane();

            model.Cena = view.Cena;
            model.Sezon = view.Sezon;
            view.EndPrice = model.PriceGiver();
            view.Destinaciq = model.PlaceGiver();
            view.Prestoi = model.SleepPlaceGiver();

            view.Output();
            
        }
     }
}
