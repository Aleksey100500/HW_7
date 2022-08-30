/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2                     00 01 02 03
5 9 2 3                     10 11 12 13 
8 4 2 4                     20 21 22 23
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
class Program
{
    public static void Main (string[] args)
    {
        int[,] matrix = new int[3,4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

        double sum = 0;
        double sum1 = 0;
        double sum2 = 0;
        double sum3 = 0;
        double average = 0;
        double average1 = 0;
        double average2 = 0;
        double average3 = 0;

        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i , 0];            
        }

        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
            sum1 = sum1 + matrix[i , 1];            
        }

        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
            sum2 = sum2 + matrix[i , 2];            
        }

        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
            sum3 = sum3 + matrix[i , 3];            
        }

        average = sum / matrix.GetLength(0);
        average1 = sum1 / matrix.GetLength(0);
        average2 = sum2 / matrix.GetLength(0);
        average3 = sum3 / matrix.GetLength(0);

        Console.Write($"{Math.Round(average,1)}; ");
        Console.Write($"{Math.Round(average1,1)}; ");
        Console.Write($"{Math.Round(average2,1)}; ");
        Console.WriteLine($"{Math.Round(average3,1)}");
    }
}