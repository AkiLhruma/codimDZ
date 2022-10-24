/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] TwoDimensionArrayInDouble()
{
    Console.Write($"Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = Math.Round(new Random().Next(1, 100) + new Random().NextDouble(), 3);
    }
    return array;
}

void ShowArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
/*
double [,] myArray = TwoDimensionArrayInDouble();
ShowArrayDouble(myArray);
*/


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет*/

int[,] TwoDimensionArrayInInt()
{
    Console.Write($"Input quantity of strings: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input quantity of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

void ShowArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ElementOfArray(int [,] array, int k, int l)
{
    if(k < array.GetLength(0) && l < array.GetLength(1)) Console.WriteLine(array[k, l]);
    else Console.WriteLine("Such element does not exist.");
    
}
/*
int[,] newArray = TwoDimensionArrayInInt();

Console.Write($"Input string index: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input column index: ");
int j = Convert.ToInt32(Console.ReadLine());

ShowArrayInt(newArray);
Console.WriteLine();
ElementOfArray(newArray, i, j);
*/


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double[] MiddleAr(int[,] array)
{
    double[] arrResoult = new double[array.GetLength(1)];
    double res = 0;
    
    for(int j = 0; j < array.GetLength(1); j++){
        for(int i = 0; i < array.GetLength(0); i++) res += array[i,j];
        res /= array.GetLength(0);
        arrResoult[j] = Math.Round(res, 1);
        res = 0;
    }
    return arrResoult;
}
/*
int[,] anotherArray = TwoDimensionArrayInInt();
ShowArrayInt(anotherArray);
Console.WriteLine();
double[] resArr = MiddleAr(anotherArray);
ShowArray(resArr);
*/