//Задача№29
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");

Console.Write("[");
int count = 1;
while (count < size)
{
    count++;
    Console.Write(new Random().Next(min, max));
    Console.Write(", ");
}
Console.Write(new Random().Next(min, max));
Console.WriteLine("]");

