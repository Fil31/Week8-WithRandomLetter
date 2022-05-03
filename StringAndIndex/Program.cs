using System;

namespace StringAndIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = ("Hello world!");
            Console.WriteLine(hello[0]);
            Console.WriteLine(hello[hello.Length-1]);
        }
    }
}
