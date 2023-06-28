// Пользователь вводит с клавиатуры M
// чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

int m = Prompt("Введите количество элементов");
int[] array = GetArr(m);
PrintArr(array);
Console.WriteLine($"-> {CountArrayElement(array)}");


int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("Введите число");
    }
    return array;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountArrayElement(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

