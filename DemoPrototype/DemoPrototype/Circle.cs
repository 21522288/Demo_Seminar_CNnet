using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle() { }

        public Circle(Circle source) : base(source)
        {
            Radius = source.Radius;
        }

        public override IPrototype Clone()
        {
            return new Circle(this);
        }
    }
}
