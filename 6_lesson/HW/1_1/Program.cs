// 1. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = int.Parse(Console.ReadLine());
    return arr;
}

void Chet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] > 0)
            sum++;
    }
    Console.WriteLine($"Чисел больше нуля: {sum}");
}

Console.Write("Введите количество элементов: ");
int[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Chet(arr_1);
