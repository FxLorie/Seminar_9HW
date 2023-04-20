// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int number1, int number2)
{
    if (number1 == number2)
        return number1;
    return SumNumbers(number1, number2 - 1) + number2;
}

Console.Clear();
Console.Write("Введите 2 числа через пробел: ");
int[] mn = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(SumNumbers(mn[0], mn[1]));