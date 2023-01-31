// Задача 66: 
//Задайте значения M и N. 
//Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Please input Numbe1: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input Numbe: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = SumOfNaturalNumbers(numberM, numberN);
if (NaturalNumbersChecking(numberM, numberN)) Console.Write(result);
else Console.WriteLine("Number's type error");

int SumOfNaturalNumbers(int num1, int num2)
{
    if (num1 < num2) return num1 + SumOfNaturalNumbers(num1 + 1, num2);

    if (num1 > num2) return num1 + SumOfNaturalNumbers(num1 - 1, num2);

    if (num1 == num2) return num1;

    return num1;
}

bool NaturalNumbersChecking(int num1, int num2)
{
    return (num1 > 0 && num2 > 0);
}