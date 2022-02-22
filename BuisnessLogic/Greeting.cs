using System;

namespace BusinessLogic
{
    public static class Greeting
    {
        public static void Welcome()
        {
            Console.WriteLine("Your name is...");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"{date.ToShortTimeString()} {date.ToShortDateString()} Hello, {name}!");
        }
    }
}
