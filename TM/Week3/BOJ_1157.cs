using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ct
{
    class Program
    {
        /** 문제 백준 1157
         * 알파벳 대소문자로 된 단어가 주어지면, 이 단어에서 가장 많이 사용된 알파벳이 무엇인지 알아내는 프로그램을 작성하시오. 단, 대문자와 소문자를 구분하지 않는다.

            입력
            첫째 줄에 알파벳 대소문자로 이루어진 단어가 주어진다. 주어지는 단어의 길이는 1,000,000을 넘지 않는다.

            출력
            첫째 줄에 이 단어에서 가장 많이 사용된 알파벳을 대문자로 출력한다. 단, 가장 많이 사용된 알파벳이 여러 개 존재하는 경우에는 ?를 출력한다.
         *
         * 
         */

        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine().ToUpper();
            int[] arr = new int[26];

            for (int i = 0; i < inputNum.Length; i++)
            {
                arr[inputNum[i] - 65] += 1;
            }

            int maxVal = arr.Max();
            int maxIndex = 0;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxVal == arr[i])
                {
                    cnt += 1;
                    maxIndex = i;
                }
            }

            if (cnt == 1)
                Console.WriteLine(char.ConvertFromUtf32(maxIndex + 65));
            else
                Console.WriteLine("?");
        }
    }
}
