using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    internal class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(Rectangle source) : base(source)
        {
            Width = source.Width;
            Height = source.Height;
        }

        public override IPrototype Clone()
        {
            return new Rectangle(this);
        }
    }
}
