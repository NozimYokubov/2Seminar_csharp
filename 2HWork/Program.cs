//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if ( num1 > 0 && num2 > 0) Console.WriteLine(1);
else if ( num1 > 0 && num2 < 0) Console.WriteLine(2);
else if ( num1 < 0 && num2 > 0) Console.WriteLine(3);
else if ( num1 < 0 && num2 < 0) Console.WriteLine(4);
else Console.WriteLine("Ошибка!");
