/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такой позиции нет
1 2 -> 4
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


int SearchElement(int[,]matrix, int[]search)
{
    int res = matrix[search[0]-1,search[1]-1];
    return res;
}

Console.Clear();
Console.Write("Введите позицию элемента массива ч/з пробел: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[7,3]; 

FillArray(array);
PrintArray(array);
Console.WriteLine();

if(position[0] > array.GetLength(0) || position[1] > array.GetLength(1))
{
    Console.WriteLine($"{position[0]} {position[1]} -> такой позиции нет.");
}
else
    Console.WriteLine($"{SearchElement(array, position)}  -> It's alive!");
