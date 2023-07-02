//Задача №41
Console.Clear();
int Promt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
//////////////////////////////////////
int[] ImputArray(int leangth)
{
    int[] array = new int[leangth];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите {i + 1}-й элемент ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"а[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int leangth = Promt("Введите количество эллементов > ");
int[] array;
array = ImputArray(leangth);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");