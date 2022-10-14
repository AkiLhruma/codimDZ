/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int InputNum(string n)
{
    Console.Write($"Input {n} number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
/*
int Stepen(int a, int b)
{
    int comp = 1;

    for(int cur = 1; cur <= b; cur++)
    
        comp *= a;

    return comp;
}

int a = InputNum("A");
int b = InputNum("B");

int num1 = Stepen(a, b);

Console.WriteLine(num1);
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
//variant 1

int SumDigits(int num)
{
    int sum = 0;

    while(num != 0){
        if(num < 0) num *= -1;
        int num1 = num % 10;
        num = num / 10;
        sum = sum + num1;
    }
    return sum;
}
*/
/*
//variant 2

int SumDigits(int num)
{
    string str = num.ToString();
    int len = str.Length;
    int[] nums = new int[len];
    int sum = 0;
    int count = 0;
    while(count < len){
        nums[count] = Convert.ToInt32(str[count].ToString());
        count++;
    }

    for(int i = 0; i < len; i++) 
        sum += nums[i];
    return sum;
}

int number = InputNum(string.Empty);

int summ = SumDigits(number);

Console.WriteLine(summ);
*/

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
m = 5 -> [1, 2, 5, 7, 19]
m = 3 -> [6, 1, 33]
*/

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}


int m = InputNum("m");

int[] myArray = RandomArray(m, 0, 100);

ShowArray(myArray);
*/

//доп. задание: создание массива с элементами от пользователя
//если инкорректный ввод сайза

int[] CreateArray(int size)
{
int[] newArray = new int[size];

for(int i = 0; i < size; i++){
    Console.Write("input number: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}
return newArray;
}

int size1 = InputNum("size");

if(size1 < 0) size1 *= -1;

int[] massiv = CreateArray(size1);

/*while(size1 < 0){
    Console.WriteLine("Incorrect input");
    Console.Write("input size: ");
    size1 = Convert.ToInt32(Console.ReadLine());
}
*/
ShowArray(massiv);