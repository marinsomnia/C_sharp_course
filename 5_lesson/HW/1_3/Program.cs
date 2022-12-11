//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] Massiv(int size, int from, int to)
{
    double[] arr = new double[size];
    Random nnew = new Random();

    for (int i = 0; i < size; i++)

        arr[i] = Math.Round(nnew.NextDouble() * (from + to) - from, 2);

    return arr;
}

void MaxMin(double[] arr)
{

    double nmax = arr[0];
    double nmin = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (nmax < arr[i])
            nmax = arr[i];
        else if (nmin > arr[i])
            nmin = arr[i];
    }

Console.Write($"Max: {nmax}, min: {nmin} ");
Console.WriteLine($"MaxMin: {nmax} - ({nmin}) = {Math.Round(nmax - nmin, 2)}");

}

double[] arr_1 = Massiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
MaxMin(arr_1);
