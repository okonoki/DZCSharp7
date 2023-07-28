// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] GetArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Введите количество строк массива: ");
int columns = GetNumber("Введите количество столбцов массива: ");

double[,] array = GetArray(rows, columns);
PrintArray(array);