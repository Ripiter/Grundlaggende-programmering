using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_H1
{
    class Lotto
    {
        static int[] lottoTal = new int[7];
        static int[] userCupon = new int[7] { 1, 2, 3, 4, 5, 7, 6, };
        static int[] winningCupons;
        static int win = 0;

        static Random randNum = new Random();
        public static void Main(string[] args)
        {

            while (1 == 1)
            {
                ChickenWinner();       
                WhatYouWon();
                Console.WriteLine("Press Enter to play again");
                Console.ReadLine();
                Console.Clear();
                win = 0;
            }


        }
        /// <summary>
        /// Calculates how many times user won
        /// </summary>
        static void ChickenWinner()
        {
            for (int i = 0; i < userCupon.Length; i++)
            {
                lottoTal[i] = randNum.Next(1, 20);              //Give lottotal a number between 1 and 20

                Console.WriteLine("lotto " + lottoTal[i]);      //Prints lottotal to check the numbers
                Console.WriteLine("user " + userCupon[i]);      //Prints user number to compare to lottotal


                winningCupons = lottoTal;

                //Compares computer numbers with users number
                //If the number is the same user gets a win
                //Numbers doesn't have to be in the same place
                for (int j = 0; j < userCupon.Length; j++)
                {
                    if (winningCupons[i] == userCupon[j]) //REMEMBER to set i and j in the right place
                        win++;
                }
            }
        }

        static void WhatYouWon()
        {
            Console.WriteLine("You won: " + win + " time(s)");
            switch (win)
            {
                case 1:
                    Console.WriteLine("You didnt win anything");
                    break;
                case 2:
                    Console.WriteLine("Congratulation you have won 10kr");
                    break;
                case 3:
                    Console.WriteLine("Congratulation you have won 25kr");
                    break;
                case 4:
                    Console.WriteLine("Congratulation you have won 50kr");
                    break;
                case 5:
                    Console.WriteLine("Congratulation you have won 100kr");
                    break;
                case 6:
                    Console.WriteLine("Congratulation you have won 250kr");
                    break;
                case 7:
                    Console.WriteLine("Congratulation you have won 1.000.000kr");
                    break;
                default:
                    Console.WriteLine("You Won Nothing!");
                    break;

            }
        }

    }
}
