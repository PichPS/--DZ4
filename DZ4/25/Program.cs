// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введи число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int C = A;

for (int i = 2; i <= B; i++)
{
    C=C*A;
}
System.Console.WriteLine($"{A},{B} -> {C}");