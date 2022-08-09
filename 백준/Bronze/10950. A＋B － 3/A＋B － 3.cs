using System;

namespace backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] num = Console.ReadLine().Split();
                int numA = int.Parse(num[0]);
                int numB = int.Parse(num[1]);

                Console.WriteLine(numA + numB);
            }
        }
    }
}
