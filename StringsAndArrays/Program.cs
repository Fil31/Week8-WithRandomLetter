using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            int stringLength = name.Length;
            Console.WriteLine($"В вашем имени {stringLength} символов!");
        }
    }
}
