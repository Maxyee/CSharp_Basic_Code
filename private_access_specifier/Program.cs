using System;

namespace private_access_specifier
{

    // main method class for private access specifier encapsulation cSharp
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle julhas = new Rectangle();
            julhas.Acceptdetails();
            julhas.Display();
            Console.ReadKey();
        }
    }
}
