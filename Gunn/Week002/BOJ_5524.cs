using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        // [백준] [5524 - 입실 관리]

        // JOI 회사에서는 방에 들어가기 위해 입실 기록을 입력할 때 알파벳으로 이름을 입력한다.
        // 그러데, 컴퓨터에 오류가 나서 대문자 소문자가 섞여버려 입실 기록이 읽기 힘들어졌다.
        // JOI 회사의 입실 기록을 읽기 쉽게 하기 위해서 기록된 이름을 모두 소문자로 변환하는
        // 프로그램을 작성하라.
        // 단, 입실 기록에는 같은 이름의 사람이 생기기도 한다.

        // [입력]
        // 첫째 줄에는 정수 N (1 <= N <= 100) 이 주어진다
        // 둘째 줄부터는 1글자 이상 20문자 이하의 영어 대문자, 소문자로만
        // 이루어지는 문자열 Si 가 주어진다.

        // [출력]
        // i 번째 줄에, i 번째 입실자의 이름을 소문자로 출력한다.

        var input = Console.ReadLine();

        int count = input != null ? int.Parse(input) : 0;
        List<string> resultList = new();

        for (int index = 0; index < count; index++)
        {
            string val = Console.ReadLine();

            if (val != null)
                resultList.Add(val);
        }

        for (int index = 0; index < resultList.Count; index++)
            Console.WriteLine(resultList[index].ToLower());
    }
}