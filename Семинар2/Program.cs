//Домашняя работа №10

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "");
int i = num;

int a1 = (i % 100) / 10;

Console.WriteLine($"{i} -> {a1}");




/*
Console.Clear();
int a1;
int a2;

Console.Write("Введите первое число: ");
a1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
a2 = int.Parse(Console.ReadLine() ?? "");

if (a1 % a2 == 0)
{
    Console.WriteLine($"Число {a1} кратно {a2}");

}
else
    Console.WriteLine($"Число {a1} не кратно {a2} остаток {a1 % a2}");
*/
