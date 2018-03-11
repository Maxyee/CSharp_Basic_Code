using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LiveCholeVaya
{
    class Program
    {
        public void ajkercodingermojanimu()
        {
            Console.WriteLine("Mama tmi to live plus coding duiter ee moja nitaso ahahah !!");
        }

        public int ayajkejogkorum(int prothomperameter, int ditiyoperameter)
        {
            int jogajog = prothomperameter + ditiyoperameter;
            return jogajog;
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            //aso aiber array niya moja nei live a ... ahahah

            int[] kidefinekorihur = {10,20,30,40};

            for (int i = 0; i < kidefinekorihur.Length; i++)
            {
                Console.WriteLine(kidefinekorihur[i]);
            }

            //for (int i = 0; i > kidefinekorihur.Length; i--)
            //{
            //    //vhulla gesi dhur
            //}

            Program p = new Program();
            p.ajkercodingermojanimu();

            Console.WriteLine(p.ayajkejogkorum(5, 5));


            string eyaminkhan = Console.ReadLine();

           
            for (int i = 0; i < eyaminkhan.Length; i++)
            {
                Console.WriteLine(eyaminkhan[i]);
            }

            for (int i = x; i < y; i++)
            {
                for (int j = y; j > x; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
