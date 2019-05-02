using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            ShowName("输入："+ str);
            Console.ReadKey();
            Console.WriteLine("Hello World 123456789!");
            Console.ReadKey();
        }
        public static void ShowName(string name) {
            Console.WriteLine(name);
        }
    }
}
