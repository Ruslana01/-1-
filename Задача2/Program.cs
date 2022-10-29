//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число а");
int NumberA=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int NumberB=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int NumberC=int.Parse(Console.ReadLine()!);
int Max=NumberA;
if (Max<NumberB)
Max=NumberB;
if (NumberC>Max)
Max=NumberC;
Console.WriteLine(Max);

