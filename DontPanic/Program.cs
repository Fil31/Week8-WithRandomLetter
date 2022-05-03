using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "K33p c4lm";
            string updatedname = name.Replace("3", "e");
            updatedname = updatedname.Replace("4", "a");
            Console.WriteLine(name);
            Console.WriteLine(updatedname);
        }
    }
}
