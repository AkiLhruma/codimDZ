/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] TwoDimensionArrayInInt(int m, int n)
{
    /*Console.Write($"Input quantity of strings: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input quantity of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());*/
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 10);
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

void SortToMin(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int m = 0; m < array.GetLength(1)-1; m++)
            {
                if(array[i,m] > array[i, m+1])
                {
                    temp = array[i, m];
                    array[i, m] = array[i, m+1];
                    array[i, m+1] = temp;
                }
            }
}
/*
int[,] newArray = TwoDimensionArrayInInt(3, 4);
ShowArrayInt(newArray);
Console.WriteLine();
SortToMin(newArray);
ShowArrayInt(newArray);
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int MinSum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int iMin = 0;

    for (int j = 0; j < array.GetLength(1); j++) minSum += array[0,j];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i,j];
        if(minSum > sum) 
        {
            minSum = sum;
            iMin = i;
        }
        Console.WriteLine(sum);
        sum = 0;
    }
    return iMin;
}
/*
int[,] arriava = TwoDimensionArrayInInt(4, 5);
ShowArrayInt(arriava);
int iMin = MinSum(arriava);
Console.WriteLine($"Minimal summ of elements is in {iMin+1} string");
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CompArr(int[,] array, int[,] arr)
{
    int[,] newArray = new int[array.GetLength(0), arr.GetLength(1)];

    if(array.GetLength(1) != arr.GetLength(0)) 
    {
        Console.WriteLine("Nah, I'm not doing it");
        return null;
    }

    else
    {
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            newArray[i,j] = 0;
            for(int m = 0; m < arr.GetLength(0); m++)
                newArray[i,j] += array[i,m] * arr[m,j];
        }
    return newArray;
    }
}

    //int[,] array1 = new int[,] {{2,4}, {3,2}};
    //int[,] array2 = new int[,] {{3,4}, {3,3}};
/*
int[,] array1 = TwoDimensionArrayInInt(2,3);
int[,] array2 = TwoDimensionArrayInInt(4,4);

ShowArrayInt(array1);
Console.WriteLine();
ShowArrayInt(array2);
Console.WriteLine();
int[,] compArr = CompArr(array1, array2);
if(compArr != null) ShowArrayInt(compArr);
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


int[] CreatArray()
{
    int[] array = new int[90];
    array[0] = 10;
    for(int i = 1; i < array.Length; i++)
        array[i] = array[i-1]+1;

    Random r = new Random();

    for(int i = array.Length-1; i >= 0; i--)
    {
        int j = r.Next(i + 1);
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[,,] CreateArrayButIn3D(int[] arr, int x, int y, int z)
{
    int[,,] array = new int[x,y,z];
    int size = arr.Length-1;

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0, m = size; k < array.GetLength(2); k++, m--)
            {
                array[i,j,k] = arr[m];
                size -= 1;
            }
    return array;
}

void Show3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i,j,k] + $"({i},{j},{k}) ");

            Console.WriteLine();
        }
    }
}
/*
int[] array = CreatArray();
ShowArray(array);
int[,,] newArraymb = CreateArrayButIn3D(array, 2, 2, 2);
Show3DArray(newArraymb);
*/


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] SpiralArr(int x, int y)
{
    int size = x*y;
    int[] array = new int[size];
    array[0] = 1;
    for(int i = 1; i < array.Length; i++)
        array[i] = array[i-1]+1;

    int[,] array2D = new int[x,y];

    for(int i = 0; i < array2D.GetLength(0); i++)
        for(int j = 0, k = i*y; j < array2D.GetLength(1); j++, k++)     //сдаюсь
            array2D[i,j] = array[k];
            
    
    return array2D;
}

int[,] spireArr = SpiralArr(4,5);
ShowArrayInt(spireArr);