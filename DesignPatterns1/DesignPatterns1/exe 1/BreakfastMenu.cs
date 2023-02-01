using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class BreakfastMenu: Menu
    {
        public BreakfastMenu()
        {
            this.StarterDish = eStarterDish.salad;
            this.MainDish = eMainDish.fish;
            this.Dessert = eDessert.iceCream;
        }


       
    }
}
