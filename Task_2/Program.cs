// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число A: ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

Console.Write("Введите число B: ");
string numberB = Console.ReadLine();
int B = int.Parse(numberB);

Console.Write("Введите число C: ");
string numberC = Console.ReadLine();
int C = int.Parse(numberC);

int max = A;
if (B > max) max = B;
if (C > max) max = C;
Console.WriteLine($"Максимальное число: {max}");


