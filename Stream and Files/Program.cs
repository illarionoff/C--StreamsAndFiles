using System;
using System.IO;
using System.Text;

namespace Stream_and_Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var sw = new StreamWriter(@"C:\Temp\Text.txt", false, Encoding.UTF8)
            ) //Create object only withing give scope. It will be destroyed byt dispose method
            {
                //Open stream
                //Write
                sw.Write("Привет");
                sw.WriteLine("New Line");
                //Close
            }

            using (var sr = new StreamReader(@"C:\Temp\Text.txt", Encoding.UTF8))
            {
                //Open stream
                //Read
                var result = sr.ReadToEnd();
                Console.WriteLine(result);
                //Close
            }
        }
    }
}