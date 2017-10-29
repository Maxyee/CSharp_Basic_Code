using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_access_specifier
{
    // private access specifier encapsulation in cSharp....
    class Rectangle
    {
        private double length;
        private double width;

        public double GetArea()
        {
            return length*width;
        }

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Width: {0}",width);
            Console.WriteLine("Area: {0}",GetArea());
        }
    }
}
