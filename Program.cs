/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число 1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
  Console.WriteLine($"max = {number1} min = {number2}");
else
    Console.WriteLine($"max = {number2} min = {number1}");
if (number1 == number2)
Console.WriteLine("числа равны");


Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3:");
int num3 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > num1)
    max = num2;
if (num3 > max)
    max = num3;
Console.WriteLine($"max = {max}");


Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if ((a % 2) < 1)
Console.WriteLine("выввели четное число");
else 
Console.WriteLine("выввели нечетное число");


Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <=num; i++) 
    if (i % 2 == 0)
Console.WriteLine($"{i} ");
*/
