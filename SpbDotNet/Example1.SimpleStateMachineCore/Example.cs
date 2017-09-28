using System;
using System.Threading.Tasks;

namespace Example1.SimpleStateMachineCore
{
    public class Example
    {
        public async Task ShowStateMachine()
        {
            FirstSync();
            await Task.Delay(1000);
            SecondSync();;
        }

        public void FirstSync()
        {
            Console.WriteLine("FCore");
        }

        public void SecondSync()
        {
            Console.WriteLine("SCore");
        }
    }
}
