// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Write a number ");

int SumNums(int num)
{
    int all_sum = 0;
    for (int i = num; num !=0; num/=10)
    
        all_sum += num % 10;
        return all_sum;
   
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
