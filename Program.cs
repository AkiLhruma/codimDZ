//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("input number one: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input number two: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if(number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.WriteLine($"Max digit is {max} and min digit is {min} ");
*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Input first digit: ");
int dig1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second digit: ");
int dig2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third digit: ");
int dig3 = Convert.ToInt32(Console.ReadLine());

int max = dig1;

if(max < dig2){
     max = dig2;
}
if(max < dig3){
    max = dig3;
}
Console.WriteLine("Max digit is " + max);
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Input digit: ");
int digit = Convert.ToInt32(Console.ReadLine());
if(digit % 2 == 0){
    Console.WriteLine(digit + " is indeed an even-number");
}
else{
    Console.WriteLine(digit + " is not an even-number");
}
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Input digit: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if(N <= 1){
    Console.Write("Incorrect input. Please, try again.");
}

while(count <= N){
    if(count % 2 == 0){
    Console.Write(count + " ");
    }
    count++;
}
*/