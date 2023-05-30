package com.augustin26.boj

// BOJ 26265 멘토와 멘티

fun main() {
    val list = mutableListOf<Pair<String, String>>()
    repeat(readLine()!!.toInt()) {
        val (a,b) = readLine()!!.split(" ")
        list.add(Pair(a, b))
    }
    list.sortWith(compareBy<Pair<String, String>> {it.first}.thenByDescending { it.second })
    list.forEach { println("${it.first} ${it.second}") }
}