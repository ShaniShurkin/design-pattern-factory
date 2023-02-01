using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class MacButton: Button
    {
        static MacButton macButtonInstance;
        static object locker = new();
       
        public static MacButton MacButtonInstance
        {
            get
            {
                if (macButtonInstance == null)
                {
                    lock (locker)
                    {
                        if (macButtonInstance == null)
                        {
                            macButtonInstance = new MacButton();
                        }

                    }

                }
                return macButtonInstance;
            }

        }
         public override string Draw()
        {
            return base.Draw()+ "of macintosh";
        }
    }
}
