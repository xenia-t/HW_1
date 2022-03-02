// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число A: ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA); 

Console.Write("Введите число B: ");
string numberB = Console.ReadLine();
int B = int.Parse(numberB);

if (A > B) Console.WriteLine($"Большее число: {A}, меньшее число: {B}");
if (A < B) Console.WriteLine($"Большее число: {B}, меньшее число: {A}");
else
{
	Console.WriteLine($"Числа A и B равны");
}

