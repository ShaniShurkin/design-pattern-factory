using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class WinCheckbox: Checkbox
    {
        static WinCheckbox winCheckboxInstance;
        static object locker = new();

        public static WinCheckbox WinCheckboxInstance
        {
            get
            {
                if (winCheckboxInstance == null)
                {
                    lock (locker)
                    {
                        if (winCheckboxInstance == null)
                        {
                            winCheckboxInstance = new WinCheckbox();
                        }

                    }

                }
                return winCheckboxInstance;
            }

        }
        public override string Draw()
        {
            return base.Draw() + "of windows";
        }
    }
}
