using System;

namespace ConsoleApp3
{

    class Program
    {
	//too aviod function overloading we use params keywords in functions
        int fun(params int[] data)
        {
            int count = 0;
            int sum = 0;
            foreach (var i in data)
            {
                sum = sum + i;
                count++;

            }
            Console.WriteLine($"No of parameters is {count} and sum of parameters is : {sum}");
            return count;
        }

        static void RefAndOut(int x , ref int y, out int z)
        {
            x = 90;
            y = 37;
            z = 21;
            x++;
            y++;
            z++;
        }
        

        static void Main(string[] args)
        { 
            Console.WriteLine("Muhaamad saad :");
            Program p1 = new Program();
            p1.fun(23, 53, 12, 43, 87);
            p1.fun();

            int a=12;
            int b = 20;
            int c = 56;
            Console.WriteLine($"Before Passing : a is {a} b is {b} and c is {c}");
            RefAndOut(2,ref b,out c);
            Console.WriteLine($"After Passing : a is {a} b is {b} and c is {c}");


            Console.ReadLine();
        }
    }
}
