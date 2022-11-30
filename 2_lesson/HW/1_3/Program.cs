// 3.Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.


string ThreeNum(int num)
{
        if (num > 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }   
        return $"{num % 10} ";
    }
    else
        return "Третьего числа нет";
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(ThreeNum(number));
