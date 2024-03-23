//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
//Пример 
//568  => 5,6,8 
//8  => 8 
//9542  => 9,5,4,2

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (num > 0)
{
    while (num > 0)
    {
        i = num % 10;
        num = num / 10;
        Console.Write(i + ",");
    }
}
else
{
    Console.WriteLine("Ошибка!");
}

