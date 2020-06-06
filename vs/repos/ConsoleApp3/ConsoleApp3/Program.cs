using System;
using IsJson;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String str = "{name:123}";
            Console.WriteLine(JsonSplit.IsJsonStart( ref str));
        }
    }
}
