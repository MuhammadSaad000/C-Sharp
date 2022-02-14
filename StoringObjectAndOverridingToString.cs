using System;
using System.IO;
namespace ConsoleApp3
{
    class Person
    {
        //In this assessment we will learn how to Print an Object on console 

        private string name;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            name = " ";
            age = 12;
        }
        public override string ToString()
        {
            return $"Name : {this.name} , Age : { this.age} \n ";
        }

        static void Main(string[] args)
        {            
            
            
            Person p1 = new Person{ name = "saad ", age = 21 };//object initializer syntax will be bypassed as we get input in object
        
            Console.WriteLine("Displaying object using object with individual data members ");
            Console.WriteLine($"Name of object is {p1.name} and age of object is {p1.age}");//printing individual data member of object 

            Console.WriteLine("After overriding ToString method ");
            Console.WriteLine(p1); //displaying namespace and class name if not ToString Method is overrided
            Console.WriteLine(p1.ToString());
            //to print an object we will override default ToString method 

            FileStream fout = new FileStream("newFile.txt", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fout);


            //Agar toString k method ko override kiye bgair object ko store karen gy to namespace aur class hi store ho gi

            sw.Write(p1);

            sw.Close();
            fout.Close();

            Console.ReadKey();

        }
    }
}
