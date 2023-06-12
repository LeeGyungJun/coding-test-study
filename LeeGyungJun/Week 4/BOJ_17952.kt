package com.augustin26.boj

// BOJ 17952 과제는 끝나지 않아!

import java.util.Stack

fun main() {
    var result = 0
    val stack = Stack<Pair<Int,Int>>()
    repeat(readLine()!!.toInt()) {
        val report = readLine()!!.split(" ").map { it.toInt() }
        if (report.first() == 1) { // 과제가 들어왔다.
            if (report[2] == 1) { // 과제가 한방컷이다.
                result += report[1] // 점수 get
            }else { // 과제가 한방컷이 아니댜.
                stack.push(Pair(report[1], report[2] - 1))
            }
        }else { // 과제가 아니다.
            if (stack.isNotEmpty()) { // 하던 과제를 하자.
                val temp = stack.pop()
                val score = temp.first
                val time = temp.second - 1
                if (time > 0) { // 과제를 다 못했다.
                    stack.push(Pair(score, time)) // 다시 스택으로
                }else { // 과제를 다 했다.
                    result += score // 점수 get
                }
            }
        }
    }
    print(result)
}