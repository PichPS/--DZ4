// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(0,100);
Console.Write($"{array[i]}, ");
}

System.Console.Write("\b\b ");