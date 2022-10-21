double InputNum(string n)
{
    Console.Write($"Input {n} number: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int PositiveNum()
{
    Console.Write("Input M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for(int i = 1; i <= m; i++){
        Console.Write("Input number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

//Console.WriteLine(PositiveNum());


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void CrossPoint()
{
    double b1 = InputNum("b1");
    double k1 = InputNum("k1");
    double b2 = InputNum("b2");
    double k2 = InputNum("k2"); 

    if(k1 == k2) Console.WriteLine("There is no crosspoint.");

    else{
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Crosspoint ({x}; {y})");
    }
}

//CrossPoint();