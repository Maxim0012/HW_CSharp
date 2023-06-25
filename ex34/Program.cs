﻿//Задача №34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
int count = 0;


for (int z = 0; z < numbers.Length; z++)
    if (numbers[z] % 2 == 0)
        count++;

Console.WriteLine($" {String.Join(" ", numbers)} --> {count} ");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
