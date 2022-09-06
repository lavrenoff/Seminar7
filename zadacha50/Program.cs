//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.Write("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[3, 4];
if (n <= 0 || n > numbers.GetLength(0))
{
    Console.WriteLine("такого элемента нет");
    return;
}

Console.Write("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
    return;
}


RandomNumbers(numbers);
WriteMassiv(numbers);

Console.WriteLine();
Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");

void RandomNumbers(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(-100, 100);
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




