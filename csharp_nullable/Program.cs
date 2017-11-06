using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.1416;

            bool? value = new bool?();

            Console.WriteLine("Nullable value: {0},{1},{2},{3}", num1,num2,num3,num4 );
            Console.WriteLine("Boolean value: {0}", value);
            Console.ReadKey();
        }
    }
}
