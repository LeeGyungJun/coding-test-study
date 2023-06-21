package com.augustin26.boj

// BOJ 1874 스택 수열

import java.util.*

fun main() {
    val result = mutableListOf<String>()
    val stack = Stack<Int>()
    var sequence = 1
    for (i in 0 until readLine()!!.toInt()) {
        val n = readLine()!!.toInt()
        while (sequence <= n) {
            stack.push(sequence)
            result.add("+")
            sequence++
        }
        if (stack.peek() == n) {
            stack.pop()
            result.add("-")
        } else {
            result.add("NO")
            break
        }
    }
    print(if (result.contains("NO")) "NO" else result.joinToString("\n"))
}