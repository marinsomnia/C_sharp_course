// Задача 1:
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

string Num(int num)

{
    if ((- 1000 < num && num < - 99) || ( num < 1000 && num > 99))
    Console.WriteLine(num);
    return $"{num/10 % 10}"; 
}

Console.WriteLine(Num(new Random().Next(100,1000)));

