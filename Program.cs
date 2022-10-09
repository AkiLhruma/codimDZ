/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
void Palindrom(int num)
{
    int num1 = num % 10;
    int num2 = num % 100 / 10;
    int num4 = num % 10000 / 1000;
    int num5 = num / 10000;

    if(num1 == num5 && num2 == num4) Console.WriteLine("yes");
    else Console.WriteLine("no");
}

Console.Write("Input 5 digit number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if(numb >= 100000 ^ numb < 10000 && numb <= -100000 ^ numb > -10000) Console.WriteLine("Incorrect input.");
else Palindrom(numb);
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
//√((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2
*/

/*
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(res, 2);
}

Console.Write("Input x1 coordinate: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1 coordinate: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1 coordinate: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2 coordinate: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2 coordinate: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z2 coordinate: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Distance is " + Distance(x1, y1, z1, x2, y2, z2));
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Cube(int n)
{
    int count = 1;

    while(count <= n){
        Console.Write(Math.Pow(count, 3) + ", ");
        count++;
    }
}

Console.Write("Input N: ");
int cifra = Convert.ToInt32(Console.ReadLine());

Cube(cifra);
*/