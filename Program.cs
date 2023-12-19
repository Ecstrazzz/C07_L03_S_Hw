﻿
// Знакомство с языками программирования (семинары)
// Урок 3. Массивы
// Домашнее задание
// 
// Задача 1: Задайте одномерный массив из 10 целых чисел
// от 1 до 100. Найдите количество элементов массива,
// значения которых лежат в отрезке [20,90].
// 
// Решение:

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 19 && array[i] < 91)
    {
        count++;
    }
}
Console.WriteLine("Количество элементов массива в отрезке [20,90] = " + count);