using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_H1
{
    class Lotto
    {
        public static void Main(string[] args)
        {
            int[] lottoTal = new int[7];
            int[] userCupon = new int[7] {1, 2, 3, 4, 5, 7, 6,};
            int win = 0;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero

            Random randNum = new Random();

            for(int i = 0; i < lottoTal.Length; i++)
            {
                lottoTal[e] = randNum.Next(0, 20);

                Console.WriteLine("lotto " + lottoTal[i]);
                Console.WriteLine("user " + userCupon[i]);

                    if (lottoTal == userCupon)      //!!!Problem!!!
                    {                               //problem is that it checks like a switch and not full
                        win = win +1;               //so it goes lottotal is 2 usercupon 1
                    }                               //it goes again, lottotal 1 and usercuper 2
                                                    //and it doesnt count as a win
            }
            Console.WriteLine("You won: " + win + " time(s)");
            Console.ReadLine();
        }
    }
}
