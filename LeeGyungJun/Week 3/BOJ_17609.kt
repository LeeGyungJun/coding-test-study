package com.augustin26.boj

//BOJ 17609 회문

import java.io.BufferedReader
import java.io.BufferedWriter
import java.io.InputStreamReader
import java.io.OutputStreamWriter

fun main(args: Array<String>)=with(BufferedReader(InputStreamReader(System.`in`))) {
    val bw= BufferedWriter(OutputStreamWriter(System.`out`))
    repeat(readLine()!!.toInt()) {
        val str = readLine()!!
        val reversed = str.reversed()
        var start = 0
        var end = str.length-1
        if (str == reversed) bw.append("0\n")
        else {
            loop@for (i in 0..str.length/2) {
                if (str[start] == str[end]) {
                    start ++
                    end --
                }else {
                    val startRemoved = str.removeRange(start..start)
                    val endRemoved = str.removeRange(end..end)
                    if (startRemoved == startRemoved.reversed() || endRemoved == endRemoved.reversed()) {
                        bw.append("1\n")
                    }else {
                        bw.append("2\n")
                    }
                    break@loop
                }
            }
        }
    }
    bw.flush()
    bw.close()
}
