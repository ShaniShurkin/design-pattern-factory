using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class WinTextbox : IControl
    {
        static WinTextbox winTextboxInstance;
        static object locker = new();

        public static WinTextbox WinTextboxInstance
        {
            get
            {
                if (winTextboxInstance == null)
                {
                    lock (locker)
                    {
                        if (winTextboxInstance == null)
                        {
                            winTextboxInstance = new WinTextbox();
                        }

                    }

                }
                return winTextboxInstance;
            }

        }
        public string Draw()
        {
            return "I'm a textbox control of windows";
        }
    }
}
