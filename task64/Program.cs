/* Задача 64. Задать значение N. Написать программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());
int m = 1;

WriteLine(AllNaturalNumber(n, m));

int AllNaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Write($"{AllNaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Write(output);
    return int.Parse(ReadLine());
}
