using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ct
{
    class Program
    {
        /** BOJ 1360
         * 되돌리기
            시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
            2 초	128 MB	1244	355	278	31.519%
            문제
            민식이는 다음과 같이 두 개의 명령만 지원하는 새로운 텍스트 에디터를 만들었다.

            “type c" : 현재 글의 가장 뒤에 문자 c를 추가한다.
            “undo t" : 이전 t초동안 수행된 작업을 역순으로 되돌린다.
            처음 텍스트 에디터는 비어있다.

            예를 들어, 다음과 같은 명령을 진행했다고 하자.

            1초 : type a
            2초 : type b
            3초 : type c
            5초 : undo 3
            3초가 끝날 때, 텍스트는 "abc"이다. 5초때, 이전 3초동안 한 작업을 역순으로 되돌려야 한다. c는 지워지고, b도 지워질 것이다. 따라서 a만 남는다.

            되돌리기가 되돌리기 될 수도 있다.

            예를 들어

            1초 : type a
            2초 : type b
            3초 : undo 2
            4초 : undo 2
            2초일 때, 텍스트는 “ab"이다. 3초때 모든 것이 되돌리기 되므로 텍스트는 빈 텍스트가 되고, 4초때 3초때 되돌리기 한 것이 되돌리기 되고, 2초때 type b한 것이 지워진다. 따라서 텍스트는 ”a"가 된다.

            명령과 수행한 시간이 주어질 때, 마지막에 남은 텍스트를 구하는 프로그램을 작성하시오.

            입력
            첫째 줄에 명령의 개수 N이 주어진다. 둘째 줄부터 N개의 줄에 명령과 수행한 시간이 주어진다. 항상 시간이 오름차순으로 주어지고, type c에서 c는 알파벳 소문자, undo t에서 t는 1보다 크거나 같고 109보다 작거나 같은 자연수이다. N은 50보다 작거나 같은 자연수이다.

            출력
            첫째 줄에 모든 명령을 수행한 후에 남아있는 텍스트를 출력한다.
         * 
         * 
         */

        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            List<Dictionary<string, string>> backupList = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> timeList = new List<Dictionary<string, string>>();

            for (int i = 0; i < cnt; i++)
            {
                string inputText = Console.ReadLine();
                string[] splitText = inputText.Split(' ');
                Dictionary<string, string> numlist = new Dictionary<string, string>();
                numlist.Clear();
                numlist.Add("type", splitText[0]);
                numlist.Add("value", splitText[1]);
                numlist.Add("time", splitText[2]);
                backupList.Add(numlist);

            }

            string temp = "";
            for (int i = 0; i < backupList.Count; i++)
            {
                Dictionary<string, string> element = backupList[i];
                Dictionary<string, string> numlist = new Dictionary<string, string>();

                if (element["type"] == "type")
                {
                    temp += element["value"];

                    numlist.Add("time", element["time"]);
                    numlist.Add("temp", temp);

                    timeList.Add(numlist);
                }
                else if (element["type"] == "undo")
                {
                    bool f = false;
                    int times = int.Parse(element["time"]) - int.Parse(element["value"]);
                    for (int x = timeList.Count - 1; x >= 0; x--)
                    {
                        Dictionary<string, string> dicData = timeList[x];

                        if (int.Parse(dicData["time"]) >= times)
                            continue;

                        f = true;
                        temp = dicData["temp"];
                        numlist.Add("time", element["time"]);
                        numlist.Add("temp", temp);
                        timeList.Add(numlist);
                        break;
                    }

                    if (f == false)
                    {
                        temp = "";
                        numlist.Add("time", element["time"]);
                        numlist.Add("temp", temp);
                        timeList.Add(numlist);
                    }
                }
            }

            Console.WriteLine(temp);
        }

    }
}
