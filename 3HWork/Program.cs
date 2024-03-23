// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (10 <= num && num <= 99)
{
    int digit1 = num % 10;
    int digit2 = num / 10 % 10;
    if (digit1 > digit2)
    {
        Console.WriteLine(digit1);
    }
    else
    {
        Console.WriteLine(digit2);
    }
}
else
{
    Console.WriteLine("Ошибка!");
}
