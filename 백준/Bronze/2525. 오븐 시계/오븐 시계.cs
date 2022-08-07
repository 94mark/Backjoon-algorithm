using System;

namespace Backjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(Console.ReadLine());
            
            b += c;
            while(b >= 60)
            {
                a++;
                b-=60;
            }
            if(a >= 24)
                a -= 24;
            
            Console.WriteLine(a + " " + b);
        }
    }
}