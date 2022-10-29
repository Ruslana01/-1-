// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число а");
int NumberA=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int NumberB=int.Parse(Console.ReadLine()!);
if (NumberA>NumberB) 
{
    Console.WriteLine(NumberA);
}    
else 
{
    Console.WriteLine (NumberB);
}
