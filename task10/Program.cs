/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int GetSecondDigit(int number)
{
    int result = new int();
    result = number % 100 / 10;
    return result;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 & number < 1000)
{
    int num2 = GetSecondDigit(number);
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Число не трехзначное");
}