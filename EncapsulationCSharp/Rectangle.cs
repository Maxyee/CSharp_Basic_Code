﻿using System;

namespace EncapsulationCSharp
{
    class Rectangle
    {
        // For public access specifier encapsulation mecanisom
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Width : {0}",width);
            Console.WriteLine("Area: {0}",GetArea());
        }       
    }
}
