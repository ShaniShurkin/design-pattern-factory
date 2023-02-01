using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal abstract class Button: IControl
    {
       
        public virtual string Draw()
        {
            return "I am a button control ";
        }
    }
}
