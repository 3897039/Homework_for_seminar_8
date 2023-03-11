// Задача 3 * : Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.


int InputUser(string message)
{
    Console.Write($"{message} => ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 5);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
    }
    Console.WriteLine();
}

int[,] MatrixC(int[,] MatrixA, int[,] MatrixB)
{
    int[,] MatrixEnd = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];
    for (int i = 0; i < MatrixEnd.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixEnd.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixA.GetLength(1); k++)
            {
                MatrixEnd[i, j] = MatrixEnd[i, j] + (MatrixA[i, k] * MatrixB[k, j]);
            }
        }
    }
    return MatrixEnd;
}

int RowMatrixA = InputUser("Введите количество строк матрицы А: ");
int ColMatrixA = InputUser("Введите количество колонок матрицы А: ");
int[,] matrixA = GenerateArray(RowMatrixA, ColMatrixA);
Console.WriteLine("Первая матрица А: ");
PrintArray(matrixA);
int RowMatrixB = InputUser("Введите количество строк матрицы B: ");
int ColMatrixB = InputUser("Введите количество колонок матрицы B: ");
int[,] matrixB = GenerateArray(RowMatrixB, ColMatrixB);
Console.WriteLine("Втoрая матрица В: ");
PrintArray(matrixB);
Console.WriteLine($"Матрица в результате произведения двух матриц = ");
PrintArray(MatrixC(matrixA,matrixB));