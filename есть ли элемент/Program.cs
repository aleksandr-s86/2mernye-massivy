/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/
using System;
using static System.Console;

Write("Введите количество строк массива ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива ");
int columns = int.Parse(ReadLine()!);
int[,] randomArray = new int[rows,columns];
Write("Введите позицию строки: ");
int m = int.Parse(ReadLine()!);
Console.Write("Введите позицию столбца: ");
int n = int.Parse(ReadLine()!);
void mas(int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        WriteLine();
        for (int j = 0; j < columns; j++)
        {
            randomArray[i,j] = new Random().Next(1,10);
            Write($"{randomArray[i,j]} ");
        }
        WriteLine();
    }
}
mas(rows,columns);
if (m<1 || n<1)
Write("Позиции строк не могут быть отрицательными");
else if (m <= rows+1 && n <= columns+1)
Write($"Значение элемента равно {randomArray[m-1,n-1]}");
else Write("Такого элемента нет в массиве");