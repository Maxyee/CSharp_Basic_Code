using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolimorphisom
{
    class ProgramData
    {
        void print(int i)
        {
            Console.WriteLine("printing int: {0}",i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing Double {0}",f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing String {0}",s);
        }

        static void Main(string[] args)
        {
            ProgramData pro = new ProgramData();

            pro.print(5);
            pro.print(5.5);
            pro.print("this is 5.5");

            Console.ReadKey();
        }
    }
}
