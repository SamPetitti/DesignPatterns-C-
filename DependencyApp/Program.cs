using System;
using MessagePrinter;
namespace DependancyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MessagePrinterService();
            service.PrintMessage();
            Console.ReadKey();
        }
    }
}
