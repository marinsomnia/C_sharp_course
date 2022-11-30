// Задача 2:
//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.

string Num(int num)

{
    if ((- 1000 < num && num < - 99) || ( num < 1000 && num > 99))
    Console.WriteLine(num);
    return $"{num} -> {num/100*10 + num % 10}"; 
}

Console.WriteLine(Num(new Random().Next(100,1000)));