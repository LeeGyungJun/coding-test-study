package com.augustin26.boj

//BOJ 1935 후위 표기식2

import java.text.DecimalFormat
import java.util.Stack

fun main() {
    val df = DecimalFormat("#.00")
    val n = readLine()!!.toInt()
    val list = mutableListOf<Double>()
    val str = readLine()!!
    repeat(n) {
        list.add(readLine()!!.toDouble())
    }
    print(df.format(solved(str, list)))
}

fun solved(str: String, list: MutableList<Double>): Double {
    val stack = Stack<Double>()
    str.forEach {
        if (it in 'A'..'Z') {
            stack.push(list[it-'A'])
        }else {
            if (stack.isNotEmpty()) {
                val temp = op(stack.pop(), stack.pop(), it)
                stack.push(temp)
            }
        }
    }
    return stack.pop()
}

fun op(b: Double, a: Double, op: Char): Double {
    return when (op) {
        '+' -> a+b
        '-' -> a-b
        '*' -> a*b
        '/' -> a/b
        else -> 0.0
    }
}