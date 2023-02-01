using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    abstract class Menu
    {
        public eStarterDish StarterDish { get; set; }
        public eMainDish MainDish { get; set; }
        public eDessert Dessert { get; set; }

        public List<Enum> getMeal()
        {
            return new List<Enum>() { StarterDish, MainDish, Dessert};
        }
    }


}
