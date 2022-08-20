// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int counter = Convert.ToString(A).Length;
int sum = 0;
int B = 0; 
for (int i = 0; i < counter; i++) 
{
    B = A - A % 10;
    sum = sum + (A - B);
    A = A / 10;
}

Console.WriteLine(sum);