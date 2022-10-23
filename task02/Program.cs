/*/
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
(row ,colum - входные данные)
/*/

int[,] array = CreateMatrix(4, 4);
int[] index = new int[2];
PrintMatrix(array);

index[0] = PrintAndGetValue("Введите строку");
index[1] = PrintAndGetValue("Введите столбец");

if (CheckIndex(array, index)) Console.WriteLine(array[index[0], index[1]]);
else Console.WriteLine("такого числа в массиве нет");

bool CheckIndex(int[,] array, int[] index)
{
    if (index[0] >= 0
        && index[0] < array.GetLength(0)
        && index[1] >= 0
        && index[1] < array.GetLength(1))
        return true;
    else { return false; }
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
            Console.Write($"{array[row, col]}   ");
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