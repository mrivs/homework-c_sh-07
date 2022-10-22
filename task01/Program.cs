/*/
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
(Округление до 2х знаков после запятой - Math.Round(value, 2))
/*/

int m = PrintAndGetValue("Введите кол-во строк");
int n = PrintAndGetValue("Введите кол-во столбцов");
double[,] array = CreateArray(m, n);
PrintArray(array);

double[,] CreateArray(int m, int n)
{
    double[,] a = new double[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row, col] = GetRandomDouble(-10, 10);
        }
    }
    return a;
}

double GetRandomDouble(int min, int max)
{
    double value = new double();
    Random rnd = new Random();
    value = rnd.Next(min, max) + rnd.NextDouble();
    value = Math.Round(value, 2);
    return value;
}

void PrintArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]}\t");
        }
        Console.WriteLine();
    }
}

int PrintAndGetValue(string message) // пишем запрос, вводим число
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}