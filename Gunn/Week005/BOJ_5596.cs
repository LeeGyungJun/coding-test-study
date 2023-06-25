// using System;
// using System.Linq;
// using System.Collections;
// using System.Collections.Generic;

// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         // [백준] [5596 - 시험 점수]

//         // 대한고등학교에 재학 중인 민국이와 만세는 4과목(정보, 수학, 과학, 영어)에 대한 시험을 봤다.
//         // 민국이와 만세가 본 4과목의 점수를 입력하면, 민국이의 총점 S 와 만세의 총점 T 중에서 큰 수를
//         // 출력하는 프로그램을 작성하시오. 단, 서로 동점일 때는 민국이의 총점 S 를 출력한다.

//         // [입력]
//         // 1번째 줄에는 순서대로 민국이의 정보, 수학, 과학, 영어 점수(정수형)가 있으며, 공백으로 구분되어 있다.
//         // 2번째 줄에는 1번째 줄과 마찬가지로 만세의 정보, 수학, 과학, 영어 점수(정수형)가 있고, 골백으로 구분되어 있다.

//         // [출력]
//         // 문제에서 요구하는 정답을 출력한다.

//         var _manScore = Console.ReadLine();
//         var _minScore = Console.ReadLine();

//         if (_manScore == null || _minScore == null)
//             return;

//         var _manArray = _manScore.Split(" ");
//         var _minArray = _minScore.Split(" ");

//         int manTotal = 0;
//         int minTotal = 0;

//         foreach (var score in _manArray)
//         {
//             if (score != null)
//                 manTotal += int.Parse(score);
//         }

//         foreach (var scroe in _minArray)
//         {
//             if (scroe != null)
//                 minTotal += int.Parse(scroe);
//         }

//         if (minTotal > manTotal)
//             Console.WriteLine(minTotal);
//         else if (manTotal > minTotal)
//             Console.WriteLine(manTotal);
//         else
//             Console.WriteLine(manTotal);
//     }
// }