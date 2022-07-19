using System;

namespace Backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(" ");

            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);

            if (m < 45)
            {
                m += 60;
                h--;
                if (h < 0)
                    h = 23;                
            }
            Console.WriteLine("{0} {1}",h,m-45);
        }
    }
}
