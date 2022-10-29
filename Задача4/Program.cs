// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N");
int NumberN=int.Parse(Console.ReadLine()!);
int i=1;
while (i<=NumberN) { 
if (i%2==0)
Console.Write(i+ ",");
i++;
}