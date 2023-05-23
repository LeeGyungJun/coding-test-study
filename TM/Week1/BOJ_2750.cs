using System;

namespace Ct
{
    /// <summary>
    /// 문제 백준 2750 수 정렬하기
    /// 
    /// 문제
    ///N개의 수가 주어졌을 때, 이를 오름차순으로 정렬하는 프로그램을 작성하시오.
    ///
    ///입력
    ///첫째 줄에 수의 개수 N(1 ≤ N ≤ 1,000)이 주어진다.둘째 줄부터 N개의 줄에는 수가 주어진다.이 수는 절댓값이 1,000보다 작거나 같은 정수이다. 수는 중복되지 않는다.
    ///
    ///출력
    ///첫째 줄부터 N개의 줄에 오름차순으로 정렬한 결과를 한 줄에 하나씩 출력한다.
    ///
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int inputm = int.Parse(Console.ReadLine());
            int[] val = new int[inputm];
            int temp = 0;

            for (int i = 0; i < val.Length; i++)
            {
                val[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < val.Length; i++)
            {
                for (int x = 0; x < val.Length; x++)
                {
                    if (val[i] < val[x])
                    {
                        temp = val[i];
                        val[i] = val[x];
                        val[x] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join("\n", val));

        }
    }
}
