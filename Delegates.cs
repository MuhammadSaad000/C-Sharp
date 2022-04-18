using System;
using static ConsoleApp5.Calculator;

namespace ConsoleApp1
{
    //Delegates in C#
    //Delegates are used to refer functions 
    //Delegates are just like signature of Functions 
    
    delegate void DelegateOne();    //return type is void and no params are passed in functions 
    delegate int sumDelegate(int a, int b);
    delegate void MessageDisplay(string s);

    delegate int MathOp(int x, int y);
    
    class Calculator
    {
        static public int Add(int a, int b)
        {
            return a + b;
        }

        static public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Display()
        {
            Console.WriteLine("Assalam o Alykum Pakistan....");
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void DisplayTwo(string s)
        {
            Console.WriteLine(s);
        }

        //Function for 4th delegate 
        static int PerformOperation(MathOp m, int x,int y)  //Math op is a function 
        {
            return m(x, y);
        }

        

        static void Main(string[] args)
        {
            //Calling Display Function Using Delegates 
            DelegateOne d1 = new DelegateOne(Display);
            d1.Invoke();

            sumDelegate d2 = Sum;
            int res = d2(4, 2);
            Console.WriteLine(res);

            MessageDisplay d3 = DisplayTwo;
            d3.Invoke("Hello World using Delegates .... ");

            Console.WriteLine(PerformOperation(Calculator.Add, 4, 1));
            Console.WriteLine(PerformOperation(Calculator.Subtract, 4, 1));



        }

    }

}