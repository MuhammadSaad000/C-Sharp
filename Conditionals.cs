//C# Conditionals --> If and ELse statements 

using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conditional Statements 
            char grade;
            Console.WriteLine("Enter your marks to check grade ");
            int marks = int.Parse(Console.ReadLine());

            if(marks>=0 && marks < 50)
            {
                grade = 'F';
                Console.WriteLine($"Your grade is : {grade} ");
            }
            else if(marks >=50 && marks< 55)
            {
                grade = 'D';
                Console.WriteLine($"Your grade is : {grade} ");

            }
            else if (marks >= 55 && marks <= 64)
            {
                grade = 'C';
                Console.WriteLine($"Your grade is : {grade} ");

            }
            else if (marks >= 65 && marks<80 )
            {
                grade = 'B';
                Console.WriteLine($"Your grade is : {grade} ");
            }
            else if (marks >=80 && marks<=100)
            {
                grade = 'A';
                Console.WriteLine($"Your grade is : {grade} ");
            }
            else
            {
                Console.WriteLine("Invaluid input marks ");
            }

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("hello mind ");
                    break;
            }

        }

    }
}
