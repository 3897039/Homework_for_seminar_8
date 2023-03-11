// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindRowMinSum(int[,] array)
{
    int RowMinSum = 0, minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumNumbers = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumNumbers += array[i, j];
        }
        if (RowMinSum == 0) RowMinSum = sumNumbers;
        if (sumNumbers < RowMinSum)
        {
            RowMinSum = sumNumbers;
            minIndex = i;
        }
    }
    return minIndex;
}

int RowInput = InputUser("Введите количество строк двумерного массива: ");
int ColInput = InputUser("Введите количество колонок двумерного массива: ");
int[,] arrayGenerate = GenerateArray(RowInput, ColInput);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(arrayGenerate);
Console.WriteLine($"Строка с  наименьшей суммой элементов: {FindRowMinSum(arrayGenerate)}");
