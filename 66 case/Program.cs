// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturElem(int m, int n)
{
    if (n > m) return n > m ? n + SumNaturElem(m, n - 1) : n;
    else return m > n ? m + SumNaturElem(m - 1, n) : m;
}
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех натуральных элементов от {m} до {n}: {SumNaturElem(m, n)}");
