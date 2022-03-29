using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    internal class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public clockType()
        {
            hours = 0; minutes = 0; seconds = 0;
        }
        public clockType(int h, int m, int s)
        {
            hours = h; minutes = m; seconds = s;
        }

        public void Time()
        {
            Console.WriteLine("Clock :");
            Console.WriteLine(hours + " : " + minutes + " : " + seconds + " ");
            timeincrease();
        }
        public void timeincrease()
        {
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 0);
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            Time();
        }
        public int elapsedTime()
        {
            int elapsed = seconds + (minutes * 60) + (hours * 60 * 60);
            return elapsed;
        }
        public int remainingTime()
        {
            int elapsed = seconds + (minutes * 60) + (hours * 60 * 60);
            int total = 86400;
            int remaining = total - elapsed;
            return remaining;
        }
        public void compareTime()
        {
            Console.Clear();
            Console.WriteLine("Enter Time Of 1st Clock : ");
            clockType t1 = input();
            Console.WriteLine("Enter Time Of 2nd Clock : ");
            clockType t2 = input();
            if (t1.hours < t2.hours)
            {
                clockType temp = t1;
                t1 = t2;
                t2 = temp;
            }

            if (t1.hours == t2.hours)
            {
                if (t1.minutes < t2.minutes)
                {
                    clockType temp = t1;
                    t1 = t2;
                    t2 = temp;
                }
                if (t1.minutes == t2.minutes)
                {
                    if (t1.seconds < t2.seconds)
                    {
                        clockType temp = t1;
                        t1 = t2;
                        t2 = temp;
                    }

                }
            }
            clockType dif=new clockType();
            if(t1.seconds < t2.seconds)
            {
                t1.seconds += 60;
                t1.minutes--;
            }
            if (t1.minutes < t2.minutes)
            {
                t1.minutes += 60;
                t1.hours--;
            }
            dif.seconds= t1.seconds-t2.seconds;
            dif.minutes= t1.minutes-t2.minutes;
            dif.hours= t1.hours-t2.hours;
            Console.WriteLine("\nDifference in time : \n");
            Console.WriteLine(dif.hours + " : " + dif.minutes + " : " + dif.seconds + " ");
        }
        public clockType input()
        {
            clockType time = new clockType();
            Console.WriteLine("Enter Time : \n");
            Console.Write("Enter Hours : ");
            time.hours = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            time.minutes = int.Parse(Console.ReadLine());
            Console.Write("Enter Seconds : ");
            time.seconds = int.Parse(Console.ReadLine());
            return time;
        }
    }
}
