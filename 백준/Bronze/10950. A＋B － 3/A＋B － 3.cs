using System;

namespace Backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < num; i++)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                
                Console.WriteLine(a + b);
            }
        }
    }
}