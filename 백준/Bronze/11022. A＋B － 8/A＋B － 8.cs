using System;
using System.Text;

namespace Backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();         
            int num = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < num; i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                
                sb.Append("Case #" + (i + 1) + ": " + a + " + " + b + " = " + (a + b) + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}