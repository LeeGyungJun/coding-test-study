package com.augustin26.boj

// BOJ 4889 안정적인 문자열

import java.io.BufferedReader
import java.io.BufferedWriter
import java.io.InputStreamReader
import java.io.OutputStreamWriter
import java.util.Stack

fun main() = with(BufferedReader(InputStreamReader(System.`in`))) {
    val bw= BufferedWriter(OutputStreamWriter(System.`out`))
    var index = 1
    loop@while (true) {
        val str = readLine()!!
        var result = 0
        if (str.contains("-")) break@loop
        val stack = Stack<Char>()
        str.forEach {
            if (it=='{') stack.push('{')
            else if (stack.size > 0) stack.pop()
            else {
                result++
                stack.push('{')
            }
        }
        bw.append("$index. ${result+stack.size/2}\n")
        index++
    }
    bw.flush()
    bw.close()
}