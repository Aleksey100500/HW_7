/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/
class Program
{
    public static void Main (string[] args)
    {
        Console.Write("Введите количество строк массива - ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов массива - ");
        int colums = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, colums];

        for(rows = 0; rows < array.GetLength(0); rows++)
        {
            for(colums = 0; colums < array.GetLength(1); colums++)
            {
                array[rows,colums] = new Random().Next(1, 10);
            }
        }

        for( int i = 0; i < array.GetLength(0); i++)
        {
            for( int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    Find(array);  
    }

    static void Find (int[,] array)
    {
        Console.Write("Введите искомое число - ");
        int find = Convert.ToInt32(Console.ReadLine());
        
        foreach (int i in array)
            if(i == find) Console.WriteLine($"{i} = {find}");
            else Console.WriteLine($"{i} = Такого числа нет");
    }
}
