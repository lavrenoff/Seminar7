//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

var random = new Random();

double[,] massiv = new double[m, n];

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = Math.Round(GetRandomDouble(random, -10, 10), 1);
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}

double GetRandomDouble(Random random, double min, double max)
{
    return min + (random.NextDouble() * (max - min));
}