using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class MacDropdown : IControl
    {
        static MacDropdown macDropdownInstance;
        static object locker = new();

        public static MacDropdown MacDropdownInstance
        {
            get
            {
                if (macDropdownInstance == null)
                {
                    lock (locker)
                    {
                        if (macDropdownInstance == null)
                        {
                            macDropdownInstance = new MacDropdown();
                        }

                    }

                }
                return macDropdownInstance;
            }

        }
        public string Draw()
        {
            return "I'm a dropdown control of macintosh";
        }
    }
}
