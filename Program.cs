int InputNum(string n)
{
    Console.Write($"Input {n} number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max);

    return array;
}

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*int[] Random3DigitArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;

    return count;
}

int size = InputNum("size");
int[] myArray = Random3DigitArray(size);

ShowArray(myArray);
int evenNumber = EvenNumber(myArray);

Console.WriteLine(evenNumber);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*int SumUneven(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0) sum += array[i];

    return sum;
}

int size = InputNum("size");
int min = InputNum("minimum");
int max = InputNum("maximum");
int[] notMyArray = RandomArray(size, min, max);

ShowArray(notMyArray);
int sum = SumUneven(notMyArray);

Console.WriteLine(sum);
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
/*
double[] RandomDoubleArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++){
        double rnd = new Random().NextDouble();
        array[i] = rnd * new Random().Next(-100, 100);                  //если только для положительных, соответственно никаких -100 здесь не нужно.
        array[i] = Math.Round(array[i], new Random().Next(1, 5));
    }
    return array;
}

void ShowDArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Double Difference(double[] array)
{
    double diff = 0;
    double minI = array[0];
    double maxI = array[0];
    for(int i = 1; i < array.Length; i++){
        if(array[i] > maxI) maxI = array[i];
        else if(array[i] < minI) minI = array[i];
    }
    
    diff = maxI - minI;
    Console.WriteLine($"{maxI} - {minI} = {diff}");
    return diff;
}

int size = InputNum("size");
double[] myArray = RandomDoubleArray(size);
ShowDArray(myArray);
double num = Difference(myArray);
*/

/*Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
предпоследний и т.д. Результат запишите в новом массиве.
Ну и примеры:
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] CompArray(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    int size1 = array.Length;
    int[] newAraray = new int[size];

    for(int i = 0; i < size; i++){
        if(i != size1 - 1){
            newAraray[i] = array[i] * array[size1 - 1];
            size1 = size1 - 1;
        }
        else newAraray[i] = array[i];
    }
    return newAraray;
}

int size = InputNum("size");
int min = InputNum("minimum");
int max = InputNum("maximum");
int[] array32 = RandomArray(size, min, max);

ShowArray(array32);
int[] compAR = CompArray(array32);
ShowArray(compAR);