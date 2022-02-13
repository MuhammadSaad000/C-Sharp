//File Handling
//using streamreader and streamwriter

using System;
using System.IO;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "THis line is written in text file using StreamWriter class ";
            string fileName = "secFile.txt";

            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(line);
            sw.Close();

            StreamReader sr = new StreamReader(fileName);
            string s = sr.ReadLine();
            Console.WriteLine(s);
            sr.Close();

            //copying contents of a file and pasting it in a new File
            string copiedFile = "Copy.txt";
            StreamWriter sw2 = new StreamWriter(copiedFile);
            sw2.WriteLine(s);
            sw2.Close();
             

        }

    }
}
