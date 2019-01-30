using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_H1
{
    class H1 {
        /// <summary>
        /// Method implementation
        /// </summary>
        #region Static Stuff
        public static double numberFirst;
        public static double numberBy;
        public static double mathPlus;
        public static double numberSqr;
        public static double powerBy;
        public static double minus;
        public static double times;
        public static double devide;
        public static double sqr;
        public static double sum;
        #endregion

        public static void Main(string[] args)
        {
            Console.WriteLine("Number 1 is minused with number 2");
            Console.WriteLine("Devide number 1 with number 2");
            Console.WriteLine("Sqareroot of number 1");
            Console.WriteLine("Number 1 is plused with number 2");
            Console.WriteLine();
            Console.Write("Number1: ");
            numberFirst = double.Parse(Console.ReadLine());
            Console.Write("Number2: ");
            numberBy = double.Parse(Console.ReadLine());
            Console.Write("Square root number: ");
            numberSqr = double.Parse(Console.ReadLine());
            Console.Write("(Number1) power by number: ");
            powerBy = double.Parse(Console.ReadLine());

            MathStuff();

            Console.WriteLine("plus " +  mathPlus); //Print the end result of the MathPlus method
            Console.WriteLine("minus " + minus); //Print the end result of the MathMinus method
            Console.WriteLine("times " + times); //Print the end result of the MathTimes method
            Console.WriteLine("devide " + devide); //Print the end result of the MathDevide method
            Console.WriteLine("sqr: " + sqr);   //Print the end result of the MathSqr method
            Console.WriteLine("power: " + sum);  //Prints the end result of the Power method
            Console.ReadKey();
        }

        public static void MathStuff()
        {
            mathPlus = MathPlus(numberFirst, numberBy); //User input gets used by MathPlus
            minus = MathMinus(numberFirst, numberBy); //User input gets used by MathMinus
            times = MathTimes(numberFirst, numberBy); //User input gets used in MathTimes
            devide = MathDevide(numberFirst, numberBy); //User input gets used in MathDevide
            sqr = MathSqr(numberSqr);                 //User input gets used by MathSqr
            sum = Power(numberFirst, powerBy); //User input gets used by power method
        }
        
        private static double MathPlus(double a, double b)
        {
            double resultPlus = a + b;

            return resultPlus;
        }
        private static double MathMinus(double a, double b)
        {
            double resultMinus = a - b;

            return resultMinus;
        }
        private static double MathTimes(double a, double b)
        {
            double resultTimes = a * b;

            return resultTimes;
        }
        private static double MathDevide(double a, double b)
        {
            double mathDevide = a / b;

            return mathDevide;
        }
        private static double MathSqr(double a)
        {
            double resultSqr = Math.Sqrt(a);

            return resultSqr;
        }
        private static double Power(double number, double po)
        {
            double total = Math.Pow(number, po); //first number to power(^) by userinput second number 

            return total;
        }
    }
}
