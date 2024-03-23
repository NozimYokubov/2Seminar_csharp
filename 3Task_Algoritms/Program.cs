// Напишите программу, 
// которая будет принимать на вход два числа и выводить, 
// кратно ли первое число второму. Если первое число некратно второму, 
// то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

int num1, num2; //объявление переменных

Console.WriteLine("Введите первое число");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;

if (result > 0)
{
    Console.WriteLine("нет, " + result);
}
else
{
    Console.WriteLine("да");
}
