//File Handling

using System;
using System.IO;	//system input output 

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("newFile.txt",FileMode.Create,FileAccess.Write);
            char a = 'X';
            //writes a single byte to a file
            fs.WriteByte((byte)a);
            fs.Close();

            //readbyte returns a ASCII Value
            FileStream rs = new FileStream("newFile.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine((char)rs.ReadByte());     //-->Typecasting

            rs.Close();

            FileStream si = new FileStream("newFile.txt", FileMode.Append, FileAccess.Write);
            string greet = "Hello Mr. Monkey This line is written using Writebyte";
            foreach(var i in greet)
            {
                si.WriteByte((byte)i);
            }
            si.Close();

            //Reading from File using ReadByte in c#
            FileStream fx = new FileStream("newFile.txt",FileMode.Open,FileAccess.Read);

            int ix;
            do
            {
                ix = fx.ReadByte();
                if (ix != -1)
                    Console.Write((char)ix);
            } while (ix != -1);


            fx.Close();
        }

    }
}
