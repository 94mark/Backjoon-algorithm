using System;
using System.Text;

namespace backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            string star = "*";

            for (int i = 0; i < t; i++)
            {
                sb.Append(star);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}