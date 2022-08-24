//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondDigitFiner(int num)
{
    int FirstDigit = num % 100;
    int TherdDigit = num % 10;
    int result = (FirstDigit - TherdDigit) / 10;

    return result;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit = SecondDigitFiner(number);

Console.WriteLine("Вторая цифра " + SecondDigit);
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int TherdDigitFiner(int num)
{
    while (num > 1000)
    {
        int index = 10;
        num = num / index;
        index = index * 10;
    }
    int FirstDigit = num % 100;
    int SecondDigit = FirstDigit / 10;
    int result = FirstDigit - SecondDigit * 10;
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int TherdDigit = TherdDigitFiner(number);

if (number < 99)
{
    Console.WriteLine("Третьей цифры нет " );
}
else
{
    Console.WriteLine("Третья цифра " + TherdDigit);
}
*/

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1000)
{
    int index = 10;
    number = number / index;
    index = index * 10;
}
 Console.WriteLine(number);
 */

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*

void WeekDays (int day) 
{
  if (day < 6) 
  {
  Console.WriteLine(day + " нет, это не выходной день(");
  }

  else Console.WriteLine(day + " да, этот день выходной!");
}

Console.Write("Введи день недели от 1 до 7: ");
int YourDay = Convert.ToInt32(Console.ReadLine());

WeekDays(YourDay);
*/