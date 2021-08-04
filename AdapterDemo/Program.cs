using System;

namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target= new Adapter();
            var d = target.CurrentDate();

            Console.WriteLine($"Current date: {d}");
        }
    }
}
