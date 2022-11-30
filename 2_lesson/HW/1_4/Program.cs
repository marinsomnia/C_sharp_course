// Задача 4:
//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

string Weekend(int num)
{
    if (num == 6 || num == 7)
    return "Выходной день!";
    else
    return "Будний день";
}

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Weekend(number));
