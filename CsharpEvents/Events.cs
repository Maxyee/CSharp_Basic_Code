using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEvents
{
    public delegate string MyDel(string str);
    class Events
    {
        event MyDel MyEvent;

        public Events()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome" + username;
        }
        static void Main(string[] args)
        {
            Events obj1 = new Events();
            string result = obj1.MyEvent("Julhas Hossain");
            Console.WriteLine(result);
        }
    }
}
