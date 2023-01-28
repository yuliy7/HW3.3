/*SНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 100000) Console.WriteLine($"Введенное Вами число не пятизначное");
else if (num < 10000) Console.WriteLine($"Введенное Вами число не пятизначное");
else
{
    int x1 = num / 10000;
    int a = num / 1000;
    int x2 = a - x1 * 10;
    int b = num / 100;
    int c = num / 10;
    int x4 = c - b * 10;
    int x5 = num - c * 10;
    if (x1 == x5 || x2 == x4) Console.WriteLine($"число {num} - полиндром");
    else Console.WriteLine($"число {num} - не полиндром");
}