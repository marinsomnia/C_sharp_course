// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.WriteLine("Write a number of elements massiv: ");

void PrintArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i]);
    }
}

void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 100);
    }
}

int[] array = new int[int.Parse(Console.ReadLine())];
FillArray(array);
PrintArray(array);