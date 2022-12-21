//Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (35)

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return Degree(a, b - 1) * a;
}

Console.WriteLine(Degree(3, 5));
