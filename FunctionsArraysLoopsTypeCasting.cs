//C# Basics

using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic is evaluated on runtime
            dynamic x1 = "This is a string evaluated : ";
            Console.WriteLine(x1.Length);

            //below statement will give runtime error not compile time error 
            //Console.WriteLine(x1.ABC);

            //get default values of datatypes 
            Console.WriteLine(default(int));
            Console.WriteLine(default(float));
            Console.WriteLine(default(string));
            Console.WriteLine(default(char));   //space will be displayed 

            //Arrays 

            int[] arr = {12,43,23,122,3 };
            //For loop
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //foreach loop 
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }


            string[] names;
            names = new string[5];

            names[0] = null;
            names[1] = "Coke";
            names[2] = "Fanta";
            names[3] = "Sprite";
            names[4] = "Pepsi";

            foreach(var i in names)
            {
                Console.WriteLine(i);
            }


            //Taking input From Console
            Console.WriteLine("Enter your Name : ");
            //string name = Console.ReadLine();
            //Function 
            Console.WriteLine("Sum is : " + sum(arr[0], arr[1] ));
            //greet(name);


            //TypeCasting in c-sharp
            int a = 10;
            double d = a;   //implicit int -> double
            
            Console.WriteLine(d + a);

            //explicit typecasting 
            double g = 9.78F;
            int gInInt = (int)g;
            Console.WriteLine(gInInt);

        }
        //Function 
        static void greet(string name)
        {
            DateTime m = DateTime.Now;
            Console.WriteLine("Good Morning : " + name + $" Its {m} ");
        }

        //Functions with optional parameters passing
        static int sum(int a,int b, int c=10)   //if c is not passed as argument its default value which is 10 willbe used 
        {
            return a+b+c;
        }

    }
}
