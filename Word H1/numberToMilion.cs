using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_H1
{
    class numberToMilion
    {
        public static string testing;
        public static void Main(string[] args)
        {
            Random r = new Random();

            float milion = 1000000f;
            float number;

            //Generates file in the path that we want, or it will be generated in debug folder
            StreamWriter file = new StreamWriter("C:/yolo/milion.txt"); 
            for (int i = 0; i < milion; i++)
            {
                number = r.Next(0, 9999);
                testing = (i +","+ number + "\r\n");//To string so it looks nices later

       //       Console.WriteLine(testing);         //To see if it works, if removed it goes faster
                file.Write(testing);                //makes a new line 
            }
                file.Close();                       //Ends writing to a file DO NOT REMOVE 

            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
