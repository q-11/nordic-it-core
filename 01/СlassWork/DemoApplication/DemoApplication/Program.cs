using System;
using System.Threading;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Привет " + name + "!");
            Console.ReadLine();
        }
    }
}
