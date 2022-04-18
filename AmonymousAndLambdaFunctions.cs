using System;


namespace ConsoleApp5
{
    delegate int MathOp(int x, int y);
    delegate void newDel();

    //Calculator class to perform math operations
    public class Calculator
    {
        static public int Add(int a, int b)
        {
            return a + b;
        }

        static public int Subtract(int a, int b)
        {
            return a - b;
        }

        static public int Multiply(int a, int b)
        {
            return a * b;
        }

    }
    //


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multicasting Delegates ");
            MathOp op = Calculator.Add;
            //referring to multiple functions 
            op += Calculator.Subtract;
            op += Calculator.Multiply;

            int res = op(3, 9);
            Console.WriteLine(res);

            //deleting a function from multicast list
            op -= Calculator.Add;


            //Anonymous Functions-- > Without name 
            MathOp sec = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine("Output using Anonymous Functions " + sec(10, 15));

            newDel del = delegate ()
            {
                Console.WriteLine("Anonymous Delegate");
            };
            del();


            //Lambda Statements =>
            MathOp p = (a, b) =>
            {
                return a - b;
            };
            //Lambda Statement
            p += (a, b) => a * b;
            //result of last entry will be shown
            Console.WriteLine(p(4, 6));

            newDel f = () => Console.WriteLine("Hello world using Lambda Statements");

            f();
        }

    }

}