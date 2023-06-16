﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ct
{
    class Program
    {
        /** 백준 1254 팰린드롬 만들기
         * 동호와 규완이는 212호에서 문자열에 대해 공부하고 있다. 규완이는 팰린드롬을 엄청나게 좋아한다. 팰린드롬이란 앞에서부터 읽으나 뒤에서부터 읽으나 같게 읽히는 문자열을 말한다.

            동호는 규완이를 위한 깜짝 선물을 준비했다. 동호는 규완이가 적어놓고 간 문자열 S에 0개 이상의 문자를 문자열 뒤에 추가해서 팰린드롬을 만들려고 한다. 동호는 가능하면 가장 짧은 문자열을 만들려고 한다.

            동호가 만들 수 있는 가장 짧은 팰린드롬의 길이를 출력하는 프로그램을 작성하시오.

            입력
            첫째 줄에 문자열 S가 주어진다. S는 알파벳 소문자로만 이루어져 있고, 길이는 최대 50이다.

            출력
            첫째 줄에 동호가 만들 수 있는 가장 짧은 팰린드롬의 길이를 출력한다.
         */

        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string reverseStr = new string(inputStr.Reverse().ToArray());

            if (inputStr == reverseStr)
                Console.WriteLine(inputStr.Length);
            else
            {
                int cnt = 0;

                while (true)
                {
                    bool palindromeCheck = true;
                    string palindromeStr = inputStr;

                    for (int i = cnt; i >= 0; i--)
                    {
                        palindromeStr += inputStr[i];
                    }

                    for (int i = cnt; i < palindromeStr.Length / 2; i++)
                    {
                        if (palindromeStr[i] != palindromeStr[palindromeStr.Length - i - 1])
                        {
                            palindromeCheck = false;
                            cnt++;
                            break;
                        }
                    }

                    if (palindromeCheck)
                    {
                        Console.WriteLine(palindromeStr.Length);
                        break;
                    }
                }
            }
        }
    }
}
