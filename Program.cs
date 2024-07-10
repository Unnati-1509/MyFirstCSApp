
using System;
using MyNewApp;

namespace MYApp{

    class Program
    {
        static void Main(String[]args) {

            Console.WriteLine("Enetr Name");
            var name = Console.ReadLine();
            Console.WriteLine("HEllo, " + name + "!");
            Console.Write("How old are you= ");
            var age= Console.ReadLine();
            NewClass.Goodbye();
        }
    }
}