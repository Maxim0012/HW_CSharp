//Домашняя работа №19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int size = number.Length;

if (size == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} является палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number}  Не является палиндром");
    }
}
else
{
    Console.WriteLine($"Ошибка: {number} - введите число ещё раз!");
}
*/


//Домашняя работа №21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Clear();
int a1;
int b1;
int c1;
int a2;
int b2;
int c2;

Console.Write("Введите координату A первой точки: ");
a1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату B первой точки: ");
b1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату C первой точки: ");
c1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату A второй точки: ");
a2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату B второй точки: ");
b2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату C второй точки: ");
c2 = int.Parse(Console.ReadLine() ?? "");

int A = a2 - a1;
int B = b2 - b1;
int C = c1 - c2;

double distance = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"A: ({a1}, {b1}, {c1}) B: ({a2}, {b2}, {c2}) ---> {distance}");
*/