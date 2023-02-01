using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    internal abstract class Checkbox : IControl
    {
        public virtual string Draw()
        {
            return "I am a checkbox control ";
        }
    }
}
