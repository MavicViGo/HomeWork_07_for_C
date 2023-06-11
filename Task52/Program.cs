/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void FillArray(int[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99, 100);
        }
    }
}


void PrintArray(int[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}


double[] SearchMidleArg(int[,]matrix, double[]resmidl)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        double temp = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = temp + matrix[i,j]; 
        }
        resmidl[j] = Math.Round(temp / (matrix.GetLength(0)), 2);
        //Console.WriteLine(resmidl[j]);
    }    
return resmidl;
}

Console.Clear();
Console.Write("Введите размер массива ч/з пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
FillArray(array);
PrintArray(array);
double[] result = new double[size[1]];
result = SearchMidleArg(array, result);
Console.WriteLine($"[{string.Join("; ", result)}]");
