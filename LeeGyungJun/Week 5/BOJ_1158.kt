package com.augustin26.boj

// BOJ 1158 요세푸스 문제

import java.util.LinkedList
import java.util.Queue

fun main() {
    val (n,k) = readLine()!!.split(" ").map { it.toInt() }
    val queue: Queue<Int> = LinkedList()
    repeat(n) { queue.add(it+1) }
    val result = mutableListOf<Int>()
    while (queue.isNotEmpty()) {
        for (i in 1 .. k) {
            if (i!=k) {
                val t =  queue.poll()
                queue.offer(t)
            }else {
                result.add(queue.poll())
            }
        }
    }
    print("<${result.joinToString()}>")
}