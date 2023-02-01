using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class SupperMenu: Menu
    {
        public SupperMenu()
        {
            this.StarterDish = eStarterDish.soup;
            this.MainDish = eMainDish.onionPie;
            this.Dessert = eDessert.fruit;
        }
    }
}
