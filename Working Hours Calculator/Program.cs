using System;

namespace Working_Hours_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start time.");
            var starth = DateTime.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter the end time.");
            var endh = DateTime.Parse(Console.ReadLine());
            
            var timespan = endh - starth;
            Console.WriteLine("I was working  " + timespan + "  hh:mm:ss.");
        }
    }
}
