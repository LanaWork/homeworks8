/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*//*
int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(0, 10);
                }
            }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}

           
int [,] SortArrayRows(int [,] array)
{
    int temp = 0; 
    for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        if (array[k,i] < array[k,j])
                        {    
                            temp = array[k,j];
                            array[k,j] = array[k,i];
                            array[k,i] = temp;
                        }
                    }
                }
            }
        
        }
    return array;
}

int [,] array = GetArray(3,4);
Console.WriteLine("Заданный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Элементы массива по убыванию:");
int [,] tempArray = SortArrayRows(array);
PrintArray(tempArray);
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(0, 10);
                }
            }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}


void SearchArrayRowsMinimalSum (int [,] array)
{
    int sumFirstString = 0;
    int sumSecondString = 0;
    int minString = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumFirstString = sumFirstString + array[i, j];
            }

            if (sumSecondString == 0)
            {
                sumSecondString = sumFirstString;
            }

            if (sumFirstString < sumSecondString)
            {
                sumSecondString = sumFirstString;
                minString = i + 1;
            }
            Console.WriteLine($"Сумма строки {sumFirstString}");
            sumFirstString = 0;
        }
    Console.WriteLine();
    Console.WriteLine($"Строка массива с минимальным значением = {minString}");
}

int [,] array = GetArray(4,3);
PrintArray(array);
Console.WriteLine();
SearchArrayRowsMinimalSum(array);
