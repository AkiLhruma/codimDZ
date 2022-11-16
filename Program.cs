/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void Row(int n)
{
    if(n <=1) Console.WriteLine(1);
    else
    {
        Console.Write(n + ", ");
        if(n > 1) Row(n-1);
    }
}

Console.Write("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());

Row(num);



/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Summ(int m, int n)
{
    if(m < 0) return Summ(m+1,n);
    if (n < 0) return Summ(m, n+1);   //изначально всё это было так просто, но пока делал что бы это работало с любыми вводными я чуть не сломал себе мозг

    if(m < n)  
    {
        m += Summ(m+1,n);
        return m;
    }
    if(n < m) 
    {
        m += Summ(m-1, n);
        return m;
    }
    return m;
}
/*
Console.Write("Input M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int res = Summ(num1, num2);
Console.WriteLine("Summ of elements from M to N is " + res);
*/


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

long Akerman(long m, long n)
{
    if(m == 0) return n+1;
    else if(m > 0 && n == 0) return Akerman(m-1, 1);
    else return Akerman(m-1, Akerman(m, n-1));
}
/*
int num1;
int num2;
do
{
    Console.Write("Input M: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input N: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    if(num1 >= 0 && num2 >= 0) break;
    Console.WriteLine("Incorrect input. Try again");
    Console.WriteLine();
}
while(num1 < 0 | num2 < 0);

long a = Akerman(num1, num2);
Console.WriteLine(a);
*/