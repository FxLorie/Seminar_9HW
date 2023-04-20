// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return AckermannFunction(m - 1, 1);
    else // if ((m > 0) && (n > 0))
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Clear();
Console.Write("Введите 2 числа через пробел: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(AckermannFunction(numbers[0], numbers[1]));