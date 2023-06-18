﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        // [백준] [1267 - 핸드폰 요금]

        // 동호는 새약대로 T 통신사의 새 핸드폰 옴머나를 샀다. 새약대로 T 통신사는 동호에게
        // 다음 두 가지 요금제 중 하나를 선택하라고 했다.

        // 1. 영식 요금제
        // 2. 민식 요금제

        // 영식 요금제는 30초마다 10원씩 청구된다. 이 말은 만약 29초 또는 그 보다 적은 시간 통화를 했으면
        // 10원이 청구된다. 만약 30초부터 59초 사이로 통화를 했으면 20원이 청구된다.

        // 민식 요금제는 60초마다 15원씩 청구된다. 이 말은 59초 또는 그 보다 적은 시간 통화를 했으면
        // 15원이 청구된다. 만약 60초부터 119초 사이로 통화했으면 30원이 청구된다.

        // 동호가 저번 달에 새약대로 T 통신사를 이용할 때 통화 시간 목록이 주어지면 어느 요금제를
        // 사용 하는 것이 저렴한지 출력하는 프로그램을 작성하시오.

        // [입력]
        // 동호가 저번 달에 이용한 통화의 개수 N 이 주어진다. N 은 20보다 작거나 같은 자연수이다.
        // 둘째 줄에 통화 시간 N 개가 주어진다. 통호 시간은 10,000 보다 작거나 같은 자연수이다.

        // [출력]
        // 첫째 줄에 싼 요금제의 이름을 출력한다.그 후 공백을 사이에 두고 요금이 몇 원 나오는지 출력한다.
        // 만약 두 요금제의 요금이 모두 같으면 영식을 먼저 쓰고 민식을 그 다음에 쓴다.
        // 영식은 Y 로, 민식은 M 으로 출력한다.

        var input = Console.ReadLine();

        if (input == null || input == "0")
            return;

        int count = int.Parse(input);

        var input2 = Console.ReadLine();

        if (input2 == null)
            return;

        var input2Split = input2.Split(" ");

        int minsooResult = 0;
        int youngsikResult = 0;

        foreach (var value in input2Split)
        {
            if (value != null && value != "0")
                CalcCallTime(int.Parse(value), ref minsooResult, ref youngsikResult);
        }

        CompareCallTime(minsooResult, youngsikResult);
    }

    private static void CalcCallTime(int callTime, ref int mResult, ref int yResult)
    {
        // 민수
        int minsooPayment = (callTime / 60) + 1;
        mResult = mResult + (minsooPayment * 15);

        // 영식
        int youngsikPayment = (callTime / 30) + 1;
        yResult = yResult + (youngsikPayment * 10);
    }

    private static void CompareCallTime(int mResult, int yResult)
    {
        if (mResult < yResult)
            Console.WriteLine("M " + mResult);
        else if (mResult > yResult)
            Console.WriteLine("Y " + yResult);
        else
            Console.WriteLine("Y M " + mResult);
    }
}