﻿//Задача №36
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine() ?? "");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);


int sum = 0;

for (int z = 0; z < numbers.Length; z += 2)
    sum = sum + numbers[z];

Console.WriteLine($" Массив : {String.Join(" ", numbers)} --> Сумма нечетных чисел: {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
