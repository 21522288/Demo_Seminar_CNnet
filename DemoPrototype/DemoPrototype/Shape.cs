using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrototype
{
    internal abstract class Shape : IPrototype
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public Shape() { }

        // Constructor sao chép từ đối tượng khác
        public Shape(Shape source)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public abstract IPrototype Clone();
    }
}
