using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphisom
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10,7);
            double a = rect.area();
            Console.WriteLine("Area {0}",a);
            Console.ReadKey();
        }
    }
}
