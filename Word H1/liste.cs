using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_H1
{
    class liste
    {
        
        public static void Main(string[] args)
        {
            // listeB.RemoveAll(item => item != 3); i know you can make it with removeall but i cant find the way to do it
            List<int> listeB = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };



            //listeB.Remove(6);
            //listeB.Remove(12);
            //listeB.Remove(18);
            for (int i = 0; i < listeB.Count; i++)
            {
                if (listeB[i] % 3 == 0) //removes all the numbers that can be divided by 3
                    listeB.RemoveAt(i);
            }



            listeB.Insert(2, 17);


            foreach (int i in listeB)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Numbers in the list");
            Console.WriteLine(listeB.Count);

            testing();
            Print();

            Console.WriteLine("Reverse");

            listeB.Reverse();
            foreach (int krak in listeB)
            {
                Console.WriteLine(krak);
            }
            Print();
            Console.ReadLine();
                void Print()
                {
                    Console.WriteLine("hello world");
                }

        }
        static void testing()
        {
            Console.WriteLine("Hello There");
            Console.WriteLine("General Kenobi");
            
            
        }

    }
}
