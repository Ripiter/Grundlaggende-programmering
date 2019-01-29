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
            int[] userCupon = new int[7] { 1, 2, 3, 4, 5, 7, 6, };
            int[] winningCupons;
            int win = 0;

            Random randNum = new Random();

            for (int i = 0; i < userCupon.Length; i++)
            {
                lottoTal[i] = randNum.Next(1, 20);              //Give lottotal a number between 1 and 20

                Console.WriteLine("lotto " + lottoTal[i]);      //Prints lottotal to check the numbers
                Console.WriteLine("user " + userCupon[i]);      //Prints user number to compare to lottotal

                
                winningCupons = lottoTal;

                for (int j = 0; j < userCupon.Length; j++)
                {
                    if (winningCupons[i] == userCupon[j]) //REMEMBER to set i and j in the right place
                        win++;
                }
            }


            Console.WriteLine("You won: " + win + " time(s)");
            Console.ReadLine();
        }
    }
}
