using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class LunchMenu: Menu
    {
        public LunchMenu()
        {
            this.StarterDish = eStarterDish.toast;
            this.MainDish = eMainDish.quiche;
            this.Dessert = eDessert.mousse;
        }

    }
}
