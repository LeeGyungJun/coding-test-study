package com.augustin26.boj

// BOJ 9242 폭탄 해체

fun main() {
    val arr = mutableListOf<List<String>>()
    repeat(5) {
        arr.add(readLine()!!.chunked(4).map {map-> if (map.length > 3) map.dropLast(1) else map })
    }
    print(solve(arr))
}

fun solve(arr: MutableList<List<String>>): String {
    val number = arrayOf("**** ** ** ****", //0
        "  *  *  *  *  *", //1
    "***  *****  ***", //2
    "***  ****  ****", //3
    "* ** ****  *  *", //4
    "****  ***  ****", //5
    "****  **** ****", //6
    "***  *  *  *  *", //7
    "**** ***** ****", //8
    "**** ****  ****" //9
    )
    val list = mutableListOf<String>()
    val result = mutableListOf<Int>()
    for (i in arr.first().indices) {
        arr.forEach {
            list.add(it[i])
        }
        val num = list.joinToString("")
        if (number.contains(num)) {
            result.add(number.indexOf(num))
            list.clear()
        }else {
            return "BOOM!!"
        }
    }
    return if (result.joinToString("").toInt() % 6 == 0) "BEER!!" else "BOOM!!"
}