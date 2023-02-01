using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class Waiter
    {
        static Waiter waiterInstance;
        static object locker = new();

        public static Waiter WaiterInstance
        {
            get
            {
                if (waiterInstance == null)
                {
                    lock (locker)
                    {
                        if (waiterInstance == null)
                        {
                            waiterInstance = new Waiter();
                        }

                    }

                }
                return waiterInstance;
            }

        }
        public List<Enum> ServeMeal(DateTime now)
        {
            List<Enum> meal = new();
            switch (now.Hour)
            {
                case >= 9 and <= 12:
                    BreakfastMenu bm = new();
                    meal = bm.getMeal();
                    break;
                case > 12 and <= 17:
                    LunchMenu lm = new();
                    meal  = lm.getMeal();            
                    break;
                case > 17 and <= 21:
                    SupperMenu sm = new();
                    meal = sm.getMeal();
                    break;
                //default:
                //    Console.WriteLine("We are sorry, the resturant is closed now \n" +
                //        "our hours: 9:00 - 21:00");
                //    break;
            }
            return meal;

        }

    }

}
