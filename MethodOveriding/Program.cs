using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOveriding
{
    class Baseclass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }

    class Subclass:Baseclass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Baseclass obj1 = new Subclass();
            obj1.Greetings();
            Console.ReadLine();
        }
    }
}
