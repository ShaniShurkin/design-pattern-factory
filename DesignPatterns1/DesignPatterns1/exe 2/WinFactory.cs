using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class WinFactory : IGUIFactory
    {
        static WinFactory factory;
        static object locker = new();
        public Button CreateButton()
        {
            return WinButton.WinButtonInstance;
        }
        public Checkbox CreateCheckbox()
        {
            return WinCheckbox.WinCheckboxInstance;
        }
        public IControl CreateSpecialControl()
        {
            return WinTextbox.WinTextboxInstance; 
        }
        public static WinFactory Factory
        {
            get
            {
                if (factory == null)
                {
                    lock (locker)
                    {
                        if (factory == null)
                        {
                            factory = new WinFactory();
                        }

                    }

                }
                return factory;
            }
        }
    }
}
