using System;
using System.Threading.Tasks;

namespace Example1.SimpleStateMachine
{
    public class Example
    {
        public async Task ShowStateMachine()
        {
            FirstSync();
            await Task.Delay(1000);
            SecondSync();
        }

        public void FirstSync()
        {
            Console.WriteLine("First");
        }

        public void SecondSync()
        {
            Console.WriteLine("Second");
        }
    }
}
