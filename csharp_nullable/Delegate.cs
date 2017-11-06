using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal delegate int NumberChanger(int n);

namespace csharp_nullable
{
    class Delegate
    {
        public static int num = 10;

        public static int AddNum(int p)
        {
            num = num + p;
            return num;
        }

        public static int MultiNum(int q)
        {
            num = num*q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        public static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            nc1(25);
            Console.WriteLine("Value of Num: {0}",getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}",getNum());
            Console.ReadKey();
        }

    }
}
