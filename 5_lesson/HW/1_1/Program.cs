//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Massiv(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int SumPos(int[] arr)
{

    int pos = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            pos++;
    }
    return pos;
}

Console.WriteLine( "Write a number");
int[] arr_1 = Massiv(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine($"{SumPos(arr_1)}");