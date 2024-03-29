﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PutNumbers(int number)
{
    if (number == 1)
        return 1.ToString();
    return number.ToString() + ", " + PutNumbers(number - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(PutNumbers(N));