/*Задача 50. Напишите программу, которая на вход принимает число и возвращает позицию (i, j) 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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
int findNumber = GetNumber("Введите искомое число в массиве случайных чисел");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);

bool existNum = false;

//проверять числа массива до тех пор пока не будет сопадения
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == findNumber)
        {
            existNum = true;
            break;
        }
    }
}

if (existNum != true)
    Console.WriteLine("Число не содержится в массиве");


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == findNumber)
        {
            Console.WriteLine($"Искомое число находится на позиции строка: {i + 1} и столбец: {j + 1}");
        }
    }
break;
}
