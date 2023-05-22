package com.augustin26.boj

// BOJ 11292 키 큰 사람

import java.io.BufferedReader
import java.io.BufferedWriter
import java.io.InputStreamReader
import java.io.OutputStreamWriter

fun main() = with(BufferedReader(InputStreamReader(System.`in`))) {
    val bw= BufferedWriter(OutputStreamWriter(System.`out`))
    while (true) {
        val n = readLine()!!.toInt()
        if (n == 0) break
        val list = mutableListOf<Triple<String, Double, Int>>()
        repeat(n) {
            val (name, tall) = readLine()!!.split(" ")
            list.add(Triple(name, tall.toDouble(), it))
        }
        val maxValue = list.maxOf { it.second }
        list.filter { it.second == maxValue }.forEach { bw.append("${it.first} ") }
        bw.append("\n")
    }
    bw.flush()
    bw.close()
}