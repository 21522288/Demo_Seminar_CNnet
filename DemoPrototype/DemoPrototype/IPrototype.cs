using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    internal interface IPrototype
    {
        IPrototype Clone();
    }
}
