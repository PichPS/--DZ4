// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
System.Console.Write($"{n} -> ");
while (n != 0)
{
    i = i + n%10;
    n=n/10;
    
}
System.Console.Write(i);