//C# Basics

using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //Formatting : How output can be formatted 
            Console.WriteLine(
                format: "{0} {1,5:NO}",  //how output will be shown 
                arg0: b*a,          //what is 1st argument
                arg1:b*b            //what is 2nd arg....
                ) ;

            //operators in C# 
            //Binary

            Console.WriteLine(plus(a, b));
            Console.WriteLine(minus(a, b));
            Console.WriteLine(multiply(a, b));
            Console.WriteLine(divide(a, b));

            //Unary Prefic INc
            Console.WriteLine(($"Value  of ++a , {++a}"));   
            Console.WriteLine(($"Value  of a  , {a}"));      



            //Unary- Postfix Increment
            Console.WriteLine(($"Value  of a++ before maintaining buffer , {a++}"));     //will output value of a 
            Console.WriteLine(($"Value of a++  after maintaining buffer ,{a}"));     //will output value of a 

            //Unary - Prefix dec 
            Console.WriteLine(($"Value  of --a , {--a}"));     //will output value of a 
            Console.WriteLine(($"Value of a  ,{a}"));     //will output value of a 


            //Unary- Postfix Dec 
            Console.WriteLine(($"Value  of a--  {a--}"));     //will output value of a 
            Console.WriteLine(($"Value of a   {a}"));     //will output value of a 


            int c=3;
            Console.WriteLine($"Value of c*=a, c is 3 {c*=a}");
            Console.WriteLine($"Value of c, c is no a*c when c =3 -->  {c}");

            //logical operators
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            char[] nameArr = new char[name.Length];
            
            foreach(var i in nameArr)
            {
                nameArr[i] = name[i];   //copying string to char array --> Assignment operator 
            }

            if((nameArr[0]=='S' || nameArr[0]=='s')  && age>18)
            {
                Console.WriteLine("You are eligible for CNIC ");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
        }
        static int plus(int a,int b)
        {
            return a + b;
        }
        static int minus(int a, int b)
        {
            return a - b;
        }
        static int multiply(int a, int b)
        {
            return a * b;
        }
        static int divide(int a, int b)
        {
            return a / b;
        }

    }
}
