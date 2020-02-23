using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual o seu nome?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine("\nSeja bem vindo(a) " + name + "! Agora são " + date.ToLongTimeString()); 
        }
    }
}
