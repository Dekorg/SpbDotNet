using System;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Example2();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }

        public static async Task Example1()
        {
            await Task.Delay(30);
            throw new NotImplementedException("bang");
        }

        public static async void Example2()
        {
            await Task.Delay(30);
            throw new NotImplementedException("bang-bang");
        }


        public static async Task Example3()
        {
            try
            {
                Execute(async () => throw new NotImplementedException("bang-bang-bang"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение из лямбды");
            }
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        public static void Execute(Action action)
        {
            action();
        }
    }
}