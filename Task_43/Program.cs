// Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double k1 = Prompt("Введите значение k1");
double b1 = Prompt("Введите значение b1");
double k2 = Prompt("Введите значение k2");
double b2 = Prompt("Введите значение b2");

Result(k1, b1, k2, b2);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Result(double k1, double b1, double k2, double b2)
{

    if ((k1 * b2 - k2 * b1) == 0)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else if (k1 * b2 == b1 * k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);
    }
}

