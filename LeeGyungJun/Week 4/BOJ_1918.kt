package com.augustin26.boj

// BOJ 1918 후위 표기식

import java.io.BufferedWriter
import java.io.OutputStreamWriter
import java.util.*

fun main() {
    val bw= BufferedWriter(OutputStreamWriter(System.`out`))
    val str = readLine()!!
    val stack = Stack<Char>()
    str.forEach {
        if (it in 'A'..'Z') {
            bw.append(it)
        }else if (it == '(') {
            stack.push(it)
        }else if (it == ')') {
            while (stack.peek() != '(') {
                bw.append(stack.pop())
            }
            stack.pop()
        }else {
            while(stack.isNotEmpty() && priority(stack.peek()) >= priority(it)) {
                bw.append(stack.pop())
            }
            stack.push(it)
        }
    }
    while (stack.isNotEmpty()) {
        bw.append(stack.pop())
    }
    bw.flush()
    bw.close()
}


fun priority(op: Char): Int {
    return if (op == '*' || op == '/') 2 else if (op == '+' || op == '-') 1 else 0
}