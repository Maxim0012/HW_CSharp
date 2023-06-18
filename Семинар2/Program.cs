//Домашняя работа №10
/*
Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "");
int i = num;

int a1 = (i % 100) / 10;

Console.WriteLine($"{i} -> {a1}");
*/
/*
Console.Clear();

Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine() ?? "");
int i = num;

int a1 = (i / 10) % 10;

Console.WriteLine($"{i} -> {a1}");
*/


//Домашняя работа №13
/*
Console.Clear();
int num;
int num1;
Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
num1 = numStr.Length;
if (num1 > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
else Console.WriteLine("третьей цифры нет");
*/



//Домашняя работа №15
/*
Console.Clear();
int a1;
Console.Write("Введите число :");
a1 = int.Parse(Console.ReadLine() ?? "");

if (a1 >= 1 && a1 <= 7)
{
    if (a1 == 6 | a1 == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}
else Console.WriteLine("Не верное число");
*/
