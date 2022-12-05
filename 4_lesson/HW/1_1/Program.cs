// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

Console.WriteLine ("Write a number A: ");
int num1 = int.Parse (Console.ReadLine ());
Console.WriteLine ("Write a number B: ");
int num2 = int.Parse (Console.ReadLine ());

int NatureSteppe (int A, int B)
{
    int steppe = 1;

    for (int i = 1; i <= B; i++)
    {
        steppe = steppe * A;
    }

    return steppe;
}


Console.WriteLine(NatureSteppe(num1, num2));