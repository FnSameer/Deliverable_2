/*
Author : Fnu Sameer
Date: 01/19/2023
Description: Enter a numeric value to get a letter grade
*/


using System;
using System.Linq.Expressions;

namespace Deliverable_2
{

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect in ISM 4300: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90) 
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade is: " + letter);
                }

                else if (grade >= 80)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade is: " + letter);
                }

                else if (grade >= 70)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade is: " + letter);

                }

                else if (grade >= 60)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade is: " + letter);
                }

                else 
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade is: " + letter);

                }

            }


            catch
            {
                Console.WriteLine("Enter a numeric value");
            }


        }

        
    }
}