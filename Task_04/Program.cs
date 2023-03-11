// Задача 4 * : Напишите программу, которая заполнит спирально квадратный массив.

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
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

int InputUser(string message)
{
    Console.Write($"{message} => ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Matrix(int[,] arrayMatrix)
{
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= arrayMatrix.GetLength(1)*arrayMatrix.GetLength(0))
    {
        arrayMatrix[i, j] = number;
        if (i <= j + 1 && i + j < arrayMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arrayMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arrayMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
        number++;
    }
    return arrayMatrix;
}

int RowMatrix = InputUser("Введите количество строк матрицы: ");
int ColMatrix = InputUser("Введите количество колонок матрицы: ");
int[,] matrix = GenerateArray(RowMatrix, ColMatrix);
Console.WriteLine("Спиральная матрица: ");
PrintArray(Matrix(matrix));