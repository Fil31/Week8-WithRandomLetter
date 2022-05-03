using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int randomletter = rnd.Next(0, name.Length);
            Console.WriteLine($"Случайная буква из вашего имени: {name[randomletter]}");
        }
    }
}
