// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введи число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= B; i++)
{
    sum = sum * A; 
}
Console.WriteLine(sum);