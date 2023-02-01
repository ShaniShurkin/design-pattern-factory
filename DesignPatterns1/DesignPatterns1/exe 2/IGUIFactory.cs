using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal interface IGUIFactory
    {
        public Button CreateButton();

        public Checkbox CreateCheckbox();

        public IControl CreateSpecialControl();
        
    }
}
