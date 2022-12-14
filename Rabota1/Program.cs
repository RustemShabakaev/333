﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int temp = number1;

void PrintSum(int num1, int num2, int sum)
{
    sum = sum + num2;
    if (num2 <= num1)
    {
        Console.Write($"{sum - num1}");
        return;
    }
    PrintSum(num1, num2 - 1, sum);

}

if (number1 < number2)
{
    PrintSum(number1, number2, temp);
}
else
{
    Console.WriteLine("Не верные числа");
}
