// Напишите программу, которая выводит третью слева цифру заданного числа или сообщает, что третьей цифры нет.
// 897 => 7
// 91 => цифры нет
// 7918 => 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * -1;
}

if (num > 99)
{
    while (num > 999)
    {
        num = num /10;
    }
    Console.WriteLine($"Третья цифра = {num % 10}");
}
else
{
    Console.WriteLine("цифры нет");
}
