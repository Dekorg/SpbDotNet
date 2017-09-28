using System;

namespace Example1.SimpleStateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new Example();
            example.ShowStateMachine().Wait();
            Console.ReadLine();
        }
    }
}
