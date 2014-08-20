using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            //Gets the time now
            Console.WriteLine("Enter your birthday in format dd/mm/yyyy");
            //Promt for user to enter their birthday in the correct format
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            //Convert it
            int age = today.Year - birthday.Year;
            //Get the difference in years
            if(today.Month<birthday.Month)
            {
                //Check if the user's birth month has already passed
                age -= 1;
                //If it has'nt subtract a year of the age
            }
            else if(today.Day<birthday.Day)
            //This won't execute unless the user's birth has passed
            {
                //Check if the user's bith date has passed
                age -= 1;
                //If it hasn't subtract a year
            }
            else if(today.Day==birthday.Day)
            {
                //Check if the user has a birthday today
                Console.WriteLine("Happy Birthday!");
                //If they do, congratulate them
            }
            Console.WriteLine("You are now "+age+" years old. And after 10 years you will be "+(age+10)+" years old");
            //Print current age and age after 10 years
        }
    }
}
