﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (NaturalNumbersChecking(number)) 
{
    Console.Write("( ");
    NaturalNumbers(number);
    Console.Write(" )");
}
else Console.WriteLine("Isn't natural number");


void NaturalNumbers(int num)
{
    if (num == 0) return;
    {
        if (num == 1) Console.Write($"{num} ");
        else Console.Write($"{num}, ");
        NaturalNumbers(num - 1);
    }

   
}

bool NaturalNumbersChecking(int num1)
{
    return num1 > 0;
}

