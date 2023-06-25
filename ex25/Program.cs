
//Задача 25
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine() ?? "");
int size = a;

for (int i = 1; i < b; i++)
{
    size = size * a;
}
Console.WriteLine($"{a} в степени {b} = {size}");


