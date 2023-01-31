// Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int nNumber = Convert.ToInt32(Console.ReadLine());


int result = AckermanFunction(mNumber, nNumber);
if (IsPositiveNumbers(mNumber, nNumber)) Console.WriteLine(result);
else Console.WriteLine("Error of numbers input");


int AckermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM > 0 && numN == 0) return AckermanFunction(numM - 1, 1);
    else if (numM > 0 && numN > 0) return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
    else return numN + 1;
}

bool IsPositiveNumbers(int num1, int num2)
{
    return (num1 >= 0 && num2 >= 0);
}