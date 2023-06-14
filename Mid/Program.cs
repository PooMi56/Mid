using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Poom
    {
        static void Main(string[] args)
        {
            int quantityOfStudent = 1;
            int[] mid, final, SOM;
            string[] Whostudent;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityOfStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            Whostudent = new string[quantityOfStudent];
            mid = new int[quantityOfStudent];
            final = new int[quantityOfStudent];
            SOM = new int[quantityOfStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int Love = 0; Love < quantityOfStudent; Love++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({Love + 1} of {quantityOfStudent}) name : ");
                Whostudent[Love] = Console.ReadLine();

                Console.Write($"Please key {Whostudent[Love]}'s middle score : ");
                mid[Love] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {Whostudent[Love]}'s final score : ");
                final[Love] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                SOM[Love] = mid[Love] + final[Love];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int WTF = 0;

            while (WTF < quantityOfStudent) { }
            {
                float grades = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (SOM[WTF] <= 49) grades = 0f;
                else if (SOM[WTF] <= 54) grades = 1f;
                else if (SOM[WTF] <= 59) grades = 1.5f;
                else if (SOM[WTF] <= 64) grades = 2f;
                else if (SOM[WTF] <= 69) grades = 2.5f;
                else if (SOM[WTF] <= 74) grades = 3f;
                else if (SOM[WTF] <= 79) grades = 3.5f;
                else if (SOM[WTF] >= 80) grades = 4f;

                #endregion

                #region Writing an if..else..if code with curly brackets.

                #endregion

                Console.WriteLine($"{WTF + 1}. {Whostudent[WTF]} have a" +
                                $" total {SOM[WTF]} score or {grades} grades.");
                WTF++;
            } while (WTF < quantityOfStudent) ;

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}