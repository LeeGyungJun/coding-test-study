package com.augustin26.boj

// BOJ 12788 제 2회 IUPC는 잘 개최될 수 있을까?

import java.io.BufferedReader
import java.io.InputStreamReader

fun main() = with(BufferedReader(InputStreamReader(System.`in`))) {
    readLine()
    val (team, member) = readLine()!!.split(" ").map { it.toInt() }
    var n = team * member
    val list = readLine()!!.split(" ").map { it.toInt() }.sortedDescending()
    var result = 0
    if (list.sum() < n) {
        print("STRESS")
    }else {
        loop@for (i in list) {
            n -= i
            result++
            if (n <= 0) {
                print(result)
                break@loop
            }
        }
    }
}
