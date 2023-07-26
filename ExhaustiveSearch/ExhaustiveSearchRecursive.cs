// N과 N개의 자연수가 주어진다. 여기서 몇개의 숫자를 골라 합을 mod 11로 했을때 나오는 가장 큰 수를 구하라.
using System;
using System.Collections.Generic;

namespace ExhaustiveSearch
{
    class Program
    {
        static int n, temp, ret;
        static List<int> v = new List<int>();
        const int mod = 11;
        static int cnt = 0;

        static void Go(int idx, int sum)
        {
            //if(ret == 10) return;
            if (idx == n)
            {
                ret = Math.Max(ret, sum % mod);
                cnt++;
                return;
            }
            Go(idx + 1, sum + v[idx]);
            Go(idx + 1, sum);
        }

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                temp = int.Parse(input[i]);
                v.Add(temp);
            }
            Go(0, 0);
            Console.WriteLine(ret);
            Console.WriteLine(cnt);
        }
    }
}
