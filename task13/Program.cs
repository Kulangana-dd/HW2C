/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int GetThreeDigitNumber(int number)
{
    int result = new int();
    while(number > 1000)
    {
        number = number/10;
    }
    result = number % 10;
      
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int num3 = GetThreeDigitNumber(number);
    Console.WriteLine(num3);    
}