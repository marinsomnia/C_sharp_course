﻿//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SummEL(int m, int n)
{

    if (m > n) return 0;
    return SummEL(m + 1, n) + m;
}

Console.WriteLine("Enter Numbers: ");
Console.WriteLine(SummEL(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
