using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
