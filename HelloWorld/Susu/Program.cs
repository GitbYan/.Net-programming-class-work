using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susu
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 0;
            Console.WriteLine("请输入一个数作为下限");
            while (!Int32.TryParse(Console.ReadLine(),out min))
            {
                Console.WriteLine("请输入一个数作为下限");
            }
            Console.WriteLine("请输入一个数作为上限");
            while (!Int32.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("请输入一个数作为上限");
            }
            int n = 0;
            int m = max - min;
            int[] a = new int[m];
            for(int i = min; i<max ; i++)
            {
                if(i <= 1)
                {
                    continue;
                }
                if(i == 2)
                {
                    a[n] = i;
                }
                bool isPrime = true;
                if (i > 2)
                {
                    for(int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        a[n] = i;
                    }
                }
                n++;
            }
            n = 0;
            bool space = false;
            foreach(int x in a)
            {
                if (x != 0)
                {
                    Console.Write(x + ",");
                    n++;
                    space = false;
                }
                if (n % 10 == 0 && !space)
                {
                    Console.WriteLine();
                    space = true;
                }
            }
            return;
        }
    }
}
