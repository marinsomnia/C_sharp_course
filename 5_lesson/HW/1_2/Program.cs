﻿//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Massiv(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int Sum(int[] arr)
{

    int pos = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            pos += arr[i];
    }
    return pos;
}


int[] arr_1 = Massiv(int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(Sum(arr_1));
