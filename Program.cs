// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введи число А");
int a = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (a>0)
{
    int number = a%10;
    summ = summ + number;
    a = a/10;
}

Console.WriteLine("сумма цифр в числе: " + summ);
