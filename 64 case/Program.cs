// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturNumb(int a)
{
    if (a % 2 == 0) Console.Write($"{a} ");
    if (a > 1) NaturNumb(a - 1);
}
Console.WriteLine("Введите число N: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Все натуральные числа от 1 до {a}:");

NaturNumb(a);
