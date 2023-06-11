package com.augustin26.boj

//BOJ 25640 MBTI

fun main() {
    val jinho = readLine()!!
    val list = mutableListOf<String>()
    repeat(readLine()!!.toInt()) {
        list.add(readLine()!!)
    }
    println(list.count { it == jinho })
}
