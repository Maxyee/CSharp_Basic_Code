using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphisom
{
    class Rectangle : Shape
    {
        private int lenght;
        private int width;

        public Rectangle(int l = 0, int w = 0)
        {
            lenght = l;
            width = w;
        }

        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width*lenght);
        }
    }
}
