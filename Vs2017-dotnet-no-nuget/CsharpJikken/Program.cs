using System;
using System.IO;

namespace CsharpJikken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello " + DateTime.Now);
            File.WriteAllText("hoge.txt", "world + " + DateTime.Now + "\n");
        }
    }
}
