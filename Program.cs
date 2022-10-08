//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int number)
{
    int resoult;

    if(number > 99 && number < 1000){
        resoult = number / 10 - number / 100 * 10;
        return resoult;
    }
    if(number < -99 && number > -1000){
        resoult = number / 10 - number / 100 * 10;
        return resoult;
    }
    else return number;
}

Console.Write("Input three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == SecondDigit(num)) Console.WriteLine("Incorrect input.");
else Console.WriteLine($"Second digit of {num} is {SecondDigit(num)}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int num)
{
    if(num > 99){
        while(num > 999){
            num = num / 10;
        }
        num = num % 10;
        return num;
    }
    if(num < -99){
        while(num < -999){
            num = num / 10;
        }
        num = num % 10;
        return num;
    }
    else return num;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == ThirdDigit(num)){
    Console.WriteLine("There is no third digit in " + ThirdDigit(num));
}
else Console.WriteLine("Third digit is " + ThirdDigit(num));
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
string WeekDay(int day)
{
    string holiday = "yes";
    string weekday = "no";
    string incor = "that's not a weekday dumbass";

    if(day < 1 ^ day > 7) return incor;
    else{
        if(day == 6 ^ day == 7) return holiday;
        else return weekday;
    }
}

Console.Write("Input weekday number: ");
int dDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(WeekDay(dDay));
*/