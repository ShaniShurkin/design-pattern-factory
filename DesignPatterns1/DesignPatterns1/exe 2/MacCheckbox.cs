using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class MacCheckbox : Checkbox
    {
        static MacCheckbox macCheckboxInstance;
        static object locker = new();

        public static MacCheckbox MacCheckboxInstance
        {
            get
            {
                if (macCheckboxInstance == null)
                {
                    lock (locker)
                    {
                        if (macCheckboxInstance == null)
                        {
                            macCheckboxInstance = new MacCheckbox();
                        }

                    }

                }
                return macCheckboxInstance;
            }

        }
        public override string Draw()
        {
            return base.Draw() + "of macintosh";
        }
    }
}
