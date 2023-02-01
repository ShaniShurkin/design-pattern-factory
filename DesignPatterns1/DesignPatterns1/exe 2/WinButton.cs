using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class WinButton: Button
    {
        static WinButton winButtonInstance;
        static object locker = new();

        public static WinButton WinButtonInstance
        {
            get
            {
                if (winButtonInstance == null)
                {
                    lock (locker)
                    {
                        if (winButtonInstance == null)
                        {
                            winButtonInstance = new WinButton();
                        }

                    }

                }
                return winButtonInstance;
            }

        }
        public override string Draw()
        {
            return base.Draw()+ "of windows ";
        }
    }
}
