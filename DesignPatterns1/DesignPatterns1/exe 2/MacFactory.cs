using DesignPatterns1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal class MacFactory : IGUIFactory
    {
        static MacFactory factory;
        static object locker = new();
        public Button CreateButton()
        {
            return MacButton.MacButtonInstance;
        }
        public Checkbox CreateCheckbox()
        {
            return MacCheckbox.MacCheckboxInstance;
        }
        public IControl CreateSpecialControl()
        {
           return MacDropdown.MacDropdownInstance;  
        }
        public static MacFactory Factory
        {
            get
            {
                if (factory == null)
                {
                    lock (locker)
                    {
                        if (factory == null)
                        {
                            factory = new MacFactory();
                        }

                    }

                }
                return factory;
            }
        }
    }


}