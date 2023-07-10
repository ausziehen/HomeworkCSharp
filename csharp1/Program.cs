/*  Задача 2: 
Напишите программу, которая на вход принимает два числа
и выдаёт большее число.

Console.Write("Input a first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num1 > num2) Console.WriteLine("largest number is: " + num1);
else Console.WriteLine("largest number is: " + num2);
*/



/* 
Задача 4: 
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double max = num1;
if (num1 < num2) max = num2;
if (num2 < num3) max = num3;
Console.WriteLine("largest number is: " + max);
*/


/* 
Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка)

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine("Yes ");
else Console.WriteLine("No ");
*/


/*
Задача 8: Напишите программу, которая на вход принимает
число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= number)
{
    if (current % 2 ==0)
    Console.Write(current + " ");
    current++;
}
*/