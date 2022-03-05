using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Name="saad",Age =20, RollNo="bsef19m037" });
            persons.Add(new Person() { Name = "ahmad", Age = 20, RollNo = "bsef19m007" });
            persons.Add(new Person() { Name = "ahad", Age = 20, RollNo = "bsef19m031" });
            persons.Add(new Person() { Name = "ali", Age = 24, RollNo = "bsef19m034" });
            persons.Add(new Person() { Name = "Shah", Age = 12, RollNo = "bsef19m004" });

           

            //capacity doubles and halves 
            Console.WriteLine(persons.Capacity);
            Console.WriteLine(persons.Count);

            //inserting new item in a list 
            persons.Insert(2, new Person()
            {
                Name = "khan",
                Age = 12,
                RollNo = "1212"
            });

            //removing all the items from list where agee double equals 20
            persons.RemoveAll(x => x.Age == 20);


            foreach(var i in persons)
            {
                Console.WriteLine(i.Name);
            }


            StreamWriter sw = new StreamWriter("persons.txt",append:true);
            foreach (var i in persons)
            {
                sw.WriteLine(JsonSerializer.Serialize(i));
            }

            sw.Close();

            StreamReader sr = new StreamReader("persons.txt");
            string text = sr.ReadToEnd();
            string[] arr = text.Split('\n');
            
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            
            sr.Close();
        }
    }
}
