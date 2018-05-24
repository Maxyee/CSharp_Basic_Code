using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread
{
    
    class ThreadCreateionProgram
    {
            public static void CallToChildThread()
            {
                Console.WriteLine("Child Thread starts");
                int sleepfor = 5000;

                Console.WriteLine("Child Thread Paused for {0} secounds", sleepfor / 1000);
                Thread.Sleep(sleepfor);
                Console.WriteLine("Child Thread resumes");
            }

            static void Main(string[] args)
            {
                ThreadStart chlidref = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating the Child thread");

                Thread childThread = new Thread(chlidref);
                childThread.Start();
                Console.ReadKey();
            }
    }
        

     
    
}
