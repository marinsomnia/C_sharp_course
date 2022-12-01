// 0. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Write a number: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
	if (number[0] == number[4] && number[1] == number[3])
    
	{
	Console.WriteLine($"{number} -  Palindrom");
    }
	
	else

	{
	Console.WriteLine($"{number} - Not palindrom");
	}
}
else

{
	Console.WriteLine($"Error: {number} - The number is not five-digit");
}

