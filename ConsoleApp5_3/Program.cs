using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int k = 2;
            int[,] nums = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i==j)
                    {
                        nums[i, j] = 0;
                        Console.Write("{0}", nums[i, j]);
                    }
                    else if (i%2==0 && j%2==0)
                    {
                        nums[i, j] = 0;
                        Console.Write("{0}", nums[i, j]);
                    }
                    else if (i%2!=0&&j%2!=0)
                    {
                        nums[i, j] = 0;
                        Console.Write("{0}", nums[i, j]);
                    }
                    else
                    {
                        nums[i, j] = 1;
                        Console.Write("{0}", nums[i, j]);
                    }
                }
                Console.WriteLine();
               
            }
            Console.ReadKey();






        }
    }
}
