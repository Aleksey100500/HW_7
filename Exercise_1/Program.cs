/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9            */
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество строк m - ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количство столбцов ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] matrix = new double[m,n];
        Random rand = new Random();

        for( int i = 0; i < matrix.GetLength(0); i++)
        {
            for( int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rand.Next(-10,10) + rand.NextDouble();
            }
        }   

        for( int i = 0; i < matrix.GetLength(0); i++)
        {
            for( int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{Math.Round(matrix[i,j], 2)} ");
            }
            Console.WriteLine();
        }   
    }
}