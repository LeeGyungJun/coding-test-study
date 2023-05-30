package com.augustin26.boj

// BOJ 5545 최고의 피자

fun main() {
    // 토핑의 종류의 수 N
    val n = readLine()!!.toInt()
    // 도우의 가격 A와 토핑의 가격 B
    val (a,b) = readLine()!!.split(" ").map { it.toInt() }
    // 도우의 열량 C
    val cal = readLine()!!.toInt()
    // 토핑없는 도우의 1원당 열량
    var result = cal/a
    val topping = mutableListOf<Int>()
    repeat(n) {
        // 토핑의 열량
        topping.add(readLine()!!.toInt())
    }
    topping.sortDescending()
    var tempPrice = a
    var tempCal = cal
    for (i in topping.indices) {
        tempPrice += b
        tempCal += topping[i]
        val tResult = tempCal / tempPrice
        if (result > tResult) {
            break
        } else {
            result = tResult
        }
    }
    println(result)
}