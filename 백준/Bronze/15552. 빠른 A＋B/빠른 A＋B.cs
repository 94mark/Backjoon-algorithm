using System;
using System.Text;

namespace Backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] str;
            
            int max = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < max; i++)
            {
                str = Console.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                sb.Append(a + b + "\n");                
            }
            Console.WriteLine(sb);
        }
    }
}