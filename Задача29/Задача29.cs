﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int [8];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next();
    Console.Write(array[i] + " ");
}
