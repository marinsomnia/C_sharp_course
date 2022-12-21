//Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "2, 4"
//N = 8 -> "2, 4, 6, 8"

string Chet(int n)
{
    if (n < 2)
        return "Error ";
    else if (n % 2 != 0)
        return Chet(n - 1);
    else if (n == 2)
        return "2";
    return $" {Chet(n - 1)}, {n} ";
}

Console.Write("Enter the digit: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Chet(n));
