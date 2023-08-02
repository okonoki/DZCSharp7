// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetResultNumber(int[,] arr, int row, int column)
{

    if (row < arr.GetLength(0) && column < arr.GetLength(1))
    {
        Console.Write(arr[row, column]);
    }
   else Console.Write("Такого числа нет в массиве!");
}

int rows = GetNumber("Введите количество строк массива: ");
int columns = GetNumber("Введите количество столбцов массива: ");

int[,] array = GetArray(rows, columns);
PrintArray(array);

int resRow = GetNumber("Введите индекс строки массива: ");
int resColumn = GetNumber("Введите индекс столбца массива: ");
GetResultNumber(array, resRow, resColumn);