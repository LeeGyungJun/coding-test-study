package com.augustin26.boj

// BOJ 14235 크리스마스 선물

//Queue는 FIFO(First In First Out)구조로 먼저들어온 순서대로 데이터가 나가게 되지만
//Priority Queue란 데이터의 우선순위를 정해 우선순위가 높은 순서대로 나가게 된다.
//우선순위 큐는 값을 비교해야하므로 null을 허용하지 않는다.
//마찬가지로 비교할 수 없는 객체는 큐를 만들 수 없다.
//내부구조는 이진트리 힙으로 구성되어 있다.

import java.io.BufferedWriter
import java.io.OutputStreamWriter
import java.util.PriorityQueue

fun main() {
    val n = readLine()!!.toInt()
    val bw= BufferedWriter(OutputStreamWriter(System.out))
    val priorityQueue = PriorityQueue(reverseOrder<Int>())
    repeat(n) {
        val str = readLine()!!.trim()
        if (str=="0") {
            bw.append("${priorityQueue.poll() ?: "-1"}\n")
        }else {
            str.split(" ").drop(1).map { it.toInt() }.forEach {
                priorityQueue.offer(it)
            }
        }
    }
    bw.flush()
    bw.close()
}