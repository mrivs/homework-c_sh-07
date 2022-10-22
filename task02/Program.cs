/*/
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
(row ,colum - входные данные)
/*/

double[,] array = CreateArray(4, 4);
PrintArray(array);

int row = PrintAndGetValue("Введите строку");
int colum = PrintAndGetValue("Введите столбец");

double value = new double();
if (row >= 0 && row < array.GetLength(0) && colum >= 0 && colum < array.GetLength(1))
    Console.WriteLine(array[row, colum]);
else
    Console.WriteLine("такого числа в массиве нет");

double[,] CreateArray(int m, int n)
{
    double[,] a = new double[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row, col] = GetRandomDouble(0, 10);
        }
    }
    return a;
}

double GetRandomDouble(int min, int max)
{
    double value = new double();
    Random rnd = new Random();
    value = rnd.Next(min, max) + rnd.NextDouble();
    value = Math.Round(value, 1);
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