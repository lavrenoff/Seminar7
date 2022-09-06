//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
double[] result_arifm = new double[m];

RandomNumbers(numbers);
WriteMassiv(numbers);


Console.WriteLine();
Console.Write(string.Join(" ", Arifm(numbers)));
Console.WriteLine();

double[] Arifm(int[,] massiv)
{
    double[] result = new double[massiv.GetLength(1)];

    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        for (int i = 0; i < massiv.GetLength(0); i++)
            result[j] = result[j] + massiv[i, j];

        result[j] = Math.Round(result[j] / massiv.GetLength(0), 2);
    }

    return result;


}

void RandomNumbers(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

