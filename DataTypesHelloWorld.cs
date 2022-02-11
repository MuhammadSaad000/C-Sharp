//C# Basics 
//Camel-case is used in C#

using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char z = 'A';
            Console.WriteLine("Char uses : " + sizeof(char) + " bytes");
            Console.WriteLine($"Minimum Value of Char : {char.MinValue} ");
            Console.WriteLine($"Maximum Value of Char : {char.MaxValue} ");



            int i = 7;  //used for both positive and negative whole numbers

            //String concatenation is done using plus operator (+)
            Console.WriteLine("Int uses : " + sizeof(int) + " bytes");
            //string interpolation
            Console.WriteLine($"Minimum Value of Int : {int.MinValue} ");
            Console.WriteLine($"Maximum Value of Int : {int.MaxValue} ");


            uint u = 4;    //used only for positive whole numbers 
            Console.WriteLine("Uint uses : " + sizeof(uint) + " bytes");
            Console.WriteLine($"Minimum Value of Uint : {uint.MinValue} ");
            Console.WriteLine($"Maximum Value of Uint : {uint.MaxValue} ");


            float f = 3.5F;
            Console.WriteLine("Float uses : " + sizeof(float) + " bytes");
            Console.WriteLine($"Minimum Value of Float : {float.MinValue} ");
            Console.WriteLine($"Maximum Value of Float : {float.MaxValue} ");

            double d = 4.43532;
            Console.WriteLine("Double uses : " + sizeof(double) + " bytes");
            Console.WriteLine($"Minimum Value of Double : {double.MinValue} ");
            Console.WriteLine($"Maximum Value of Double : {double.MaxValue} ");

            decimal x = 2.1M;
            Console.WriteLine("decimal uses : " + sizeof(decimal) + " bytes");
            Console.WriteLine($"Minimum Value of Int : {decimal.MinValue} ");
            Console.WriteLine($"Maximum Value of Int : {decimal.MaxValue} ");

            //Assigning null values to variables we use question marks 
            int? n = null;
            n  = 30;    //if not assigned below values statement will log to zero
            Console.WriteLine(n.GetValueOrDefault());


            //object is used to store any type of data 
            //object is checked at compile time
            object x1 = 12;
            object x2 = "Strign stored ";
            object x3 = 3.3;
            string x4 = "This is stored using string data type";

            //length of x2 
            Console.WriteLine(x4.Length);
            int len1 = ((string)x2).Length;  //type casting 
            Console.WriteLine(len1);

            //Dynamic behaves same as object but it is run time checked

        }
    }
}
