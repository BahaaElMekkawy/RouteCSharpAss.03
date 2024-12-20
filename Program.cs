using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp1
{
    internal class Program
    {

        class Number
        {
            public int Value;
        }
        static void Main(string[] args)
        {
            /*1- Write a program that takes a number from the user then print yes if that number can 
                 be divided by 3 and 4 otherwise print no.*/

            Console.WriteLine("Please Enter A Number To Check");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 3 == 0 && Number % 4 == 0)
                Console.WriteLine("Yes.");
            else
                Console.WriteLine("No");

            /*************************************************************************************************/
            /*2- Write a program that allows the user to insert an integer then print negative if it is 
             negative number otherwise print positive*/

            Console.WriteLine("Please Enter A Number To Check");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            if (Number1 < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Positive");
            /*************************************************************************************************/
            /*3- Write a program that takes 3 integers from the user then prints the max element and the min element.*/
            Console.WriteLine("Please 3 Numbers To Get The Max");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            int NumberThree = Convert.ToInt32(Console.ReadLine());
            int Max = NumberOne;
            if (NumberOne > NumberTwo && NumberOne > NumberThree)
                Max = NumberOne;
            else if (NumberTwo > NumberOne && NumberTwo > NumberThree)
                Max = NumberTwo;
            else
                Max = NumberThree;
            Console.WriteLine($"The Max Number is {Max}");
            /*************************************************************************************************/
            /*4- Write a program that allows the user to insert an integer number then check If a number is even or odd.*/

            Console.WriteLine("Please Enter A Number To Check");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            /*************************************************************************************************/
            /*5- Write a program that takes character from the user then if it is a vowel 
                 chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/

            Console.WriteLine("Please Enter A Char To Check");
            Char character = Convert.ToChar(Console.ReadLine());
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
            /*************************************************************************************************/
            /*7- Write a program that allows the user to insert an integer then 
                 print a multiplication table up to 12.*/

            Console.WriteLine("Please Enter A Number To Get The Multiplication Table");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Res = 1;
            for (int i = 1; i <= 12; ++i)
            {
                Res = Num1 * i;
                Console.WriteLine(Res);
            }
            /*************************************************************************************************/
            /*8- Write a program that allows to user to insert number then print all even numbers between 1 to this number*/

            Console.WriteLine("Please Enter A Number To Get The Even numbers Between");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < Num2; i = i + 2)
            {
                Console.WriteLine(i);
            }
            /*************************************************************************************************/
            /*9- Write a program that takes two integers then prints the power*/

            Console.WriteLine("Please Enter A Number");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Power");
            int Pow = Convert.ToInt32(Console.ReadLine());
            int Result = Num3;
            for (int i = 1; i < Pow; ++i)
            {
                Result *= Num3;
            }
            Console.WriteLine(Result);

            /*************************************************************************************************/
            /*11- Write a program to input the month number and print the number of days in that month.*/

            Console.WriteLine("Please Enter The Month Number");
            int Month = Convert.ToInt32(Console.ReadLine());
            switch (Month)
            {
                case 1:
                    Console.WriteLine("January has 31 days.");
                    break;
                case 2:
                    Console.WriteLine("February has 28 or 29 days.");
                    break;
                case 3:
                    Console.WriteLine("March has 31 days.");
                    break;
                case 4:
                    Console.WriteLine("April has 30 days.");
                    break;
                case 5:
                    Console.WriteLine("May has 31 days.");
                    break;
                case 6:
                    Console.WriteLine("June has 30 days.");
                    break;
                case 7:
                    Console.WriteLine("July has 31 days.");
                    break;
                case 8:
                    Console.WriteLine("August has 31 days.");
                    break;
                case 9:
                    Console.WriteLine("September has 30 days.");
                    break;
                case 10:
                    Console.WriteLine("October has 31 days.");
                    break;
                case 11:
                    Console.WriteLine("November has 30 days.");
                    break;
                case 12:
                    Console.WriteLine("December has 31 days.");
                    break;
                default:
                    Console.WriteLine("Invalid month number! Please enter a number between 1 and 12.");
                    break;
            }

            /*************************************************************************************************/
            /*18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                    - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                    - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                    - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                    - If the worker takes more than 5 hours, they are required to leave the company. 
                    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.*/

            Console.WriteLine("Please Enter Number of Hours Taken to Do The Task");
            int Hours = Convert.ToInt32(Console.ReadLine());
            if (Hours >= 2 && Hours <= 3)
                Console.WriteLine("Highly Efficient");
            else if (Hours >= 3 && Hours <= 4)
                Console.WriteLine("Please Increase your Speed");
            else if (Hours >= 4 && Hours <= 5)
                Console.WriteLine("You Need To Get Training to Increase Your Speed");
            else if (Hours > 5)
                Console.WriteLine("You Have to Leave the Company");
        }
    }
}
