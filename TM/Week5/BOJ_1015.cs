﻿using System;
using System.Text;

namespace Ct
{
    class Program
    {
        /** BOJ 1015 수열정리
         * 문제
            P[0], P[1], ...., P[N-1]은 0부터 N-1까지(포함)의 수를 한 번씩 포함하고 있는 수열이다. 수열 P를 길이가 N인 배열 A에 적용하면 길이가 N인 배열 B가 된다. 적용하는 방법은 B[P[i]] = A[i]이다.

            배열 A가 주어졌을 때, 수열 P를 적용한 결과가 비내림차순이 되는 수열을 찾는 프로그램을 작성하시오. 비내림차순이란, 각각의 원소가 바로 앞에 있는 원소보다 크거나 같을 경우를 말한다. 만약 그러한 수열이 여러개라면 사전순으로 앞서는 것을 출력한다.

            입력
            첫째 줄에 배열 A의 크기 N이 주어진다. 둘째 줄에는 배열 A의 원소가 0번부터 차례대로 주어진다. N은 50보다 작거나 같은 자연수이고, 배열의 원소는 1,000보다 작거나 같은 자연수이다.

            출력
            첫째 줄에 비내림차순으로 만드는 수열 P를 출력한다.
         * 
         */


        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int lenCnt = int.Parse(Console.ReadLine());
            int[] iArr = new int[lenCnt];

            string seq = Console.ReadLine();
            int[] seqArr = Array.ConvertAll<string, int>(seq.Split(' '), int.Parse);
            int[] backupArr = new int[seqArr.Length];

            Array.Copy(seqArr, backupArr, seqArr.Length);
            Array.Sort(seqArr);

            for (int i = 0; i < backupArr.Length; i++)
            {
                for (int x = 0; x < seqArr.Length; x++)
                {
                    if (backupArr[i] == seqArr[x])
                    {
                        iArr[i] = x;
                        seqArr[x] = -1;
                        break;
                    }
                }
            }

            for (int i = 0; i < iArr.Length; i++)
            {
                sb.Append(iArr[i].ToString() + " ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);

        }

    }
}
