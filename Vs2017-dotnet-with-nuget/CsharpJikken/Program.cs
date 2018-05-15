using Newtonsoft.Json;
using System;
using System.IO;

namespace CsharpJikken
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = JsonConvert.SerializeObject(
                new { message = "hello", time = DateTime.Now },
                Formatting.Indented
            );
            Console.WriteLine(json);
            File.WriteAllText("hoge.txt", json);
        }
    }
}
