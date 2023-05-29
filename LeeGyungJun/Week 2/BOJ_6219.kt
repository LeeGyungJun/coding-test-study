package com.augustin26.boj

// BOJ 6219 소수의 자격

import kotlin.math.sqrt

fun main() {
    var result = 0
    val (a,b,d) = readLine()!!.split(" ")
    for (i in a.toInt()..b.toInt()) {
        if (i.toString().contains(d)) result += isSosu(i)
    }
    print(result)
}

fun isSosu(n: Int) : Int {
    if (n == 1) return 0
    for (i in 2..sqrt(n.toDouble()).toInt()) {
        if (n%i == 0) {
            return 0
        }
    }
    return 1
}