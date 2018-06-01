using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChangerMulticast(int n);
namespace CShapeDelegates
{
    class MulticastDelegate
    {
        static int num = 10;

        public static int AddNum(int k)
        {
            num += k;
            return num;
        }

        public static int MutiNum(int j)
        {
            num *= j;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            NumberChangerMulticast nc;
            NumberChangerMulticast nc1 = new NumberChangerMulticast(AddNum);
            NumberChangerMulticast nc2 = new NumberChangerMulticast(MutiNum);

            nc = nc1;
            nc += nc2;

            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
            

        }
    }
}
