/*/
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
(Округление до 2х знаков - Math.Round(value, 2))
/*/
int[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(PrintArrayOfDouble(SRA(matrix)));

double[] SRA(int[,] array)
{
    double[] sr = new double[array.GetLength(1)];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            sr[col] = sr[col] + array[row, col];
        }

    }
    for (int i = 0; i < sr.Length; i++)
    {
        sr[i] = sr[i] / array.GetLength(0);
        sr[i] = Math.Round(sr[i], 2);
    }

    return sr;
}

string PrintArrayOfDouble(double[] array) // пишем массив double в строку
{
    string str = "Среднее арифметическое каждого столбца: "+string.Join("; ",array)+".";
    return str;
}
int[,] CreateMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            array[row, col] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
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