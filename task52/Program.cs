/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//получает число с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

/*int SumDiag(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}
*/

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();


/*
double sum = 0;
double count = matrix.GetLength(0);
double result = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < count; i++)
    {
        sum = sum + matrix[i, j];
        result = sum/count;
    }
    Console.WriteLine($"среднее арифметическое {j+1} столбца: {Math.Round(result,1)} ");
    break;
    j++;
}
*/

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    double count = matrix.GetLength(0);
    double result = 0;
    for (int i = 0; i < count; i++)
    {
        sum = sum + matrix[i, j];
        result = sum / count;
    }
    Console.WriteLine($"среднее арифметическое {j + 1} столбца: {Math.Round(result, 1)} ");
}