using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Time : \n");
            Console.Write("Enter Hours : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter Seconds : ");
            int s = int.Parse(Console.ReadLine());
            clockType time = new clockType(h, m, s);
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    int elapsed = time.elapsedTime();
                    Console.WriteLine("Elapsed Time Of Day in Seconds : " + elapsed);

                }
                else if (option == 2)
                {
                    int remaining = time.remainingTime();
                    Console.WriteLine("Remaining Time Of Day in Seconds : " + remaining);
                }
                else if (option == 3)
                {
                    time.compareTime();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    time.Time();
                }
                else if (option == 5)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Option.\nTry Again");
                }
                Console.WriteLine("Press Any Key To Continue....");
                Console.ReadKey();
            }
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("          Choose One Option ...\n");
            Console.WriteLine("1.Elapsed time of the day of a clock in seconds");
            Console.WriteLine("2.Remaining time of the day of a clock in seconds");
            Console.WriteLine("3.Determines and outputs how far apart in time two clocks are");
            Console.WriteLine("4.View Current Time\n");
            Console.WriteLine("Your Option ...");
            int op;
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
