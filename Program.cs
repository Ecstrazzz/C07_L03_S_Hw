﻿// Знакомство с языками программирования (семинары)
// Урок 3. Массивы
// Домашнее задание
// 
// Задача 1: Задайте одномерный массив из 10 целых чисел
// от 1 до 100. Найдите количество элементов массива,
// значения которых лежат в отрезке [20,90].
// 
// Решение:
//
// int[] array = new int[10];
// int count = 0;
//
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 101);
//     Console.Write(array[i] + " ");
//     if (array[i] > 19 && array[i] < 91)
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество элементов массива в отрезке [20,90] = " + count);
//
//-----------------------------------------------------
//
// Задача 2: Задайте массив на 10 целых чисел. Напишите
// программу, которая определяет количество чётных чисел
// в массиве.
//
// Решение:
// 
// int[] array = new int[10];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 11);
//     Console.Write(array[i] + " ");
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество чётных чисел = " + count);
//
//-----------------------------------------------------
//
// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
//
// Решение:
//
// Console.WriteLine("Введите размер массива");
// int count = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[count];
//
// for (int i = 0; i < count; i++)
// {
//     array[i] = new Random().Next(101, 10000);
//     array[i] /= 100;
//     Console.Write(array[i] + " ");
// }
//
// Console.WriteLine();
//
// double min = array[0];
// double max = array[0];
//
// for (int i = 0; i < count; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
//
// Console.WriteLine($"\nМинимальный = {min} | Максимальный = {max}");
// Console.WriteLine($"\nРазница между Мин и Макс злементом = {max - min}");
//
//-----------------------------------------------------
//
// Задача 4**(не обязательно): Дано натуральное число в
// диапазоне от 1 до 100 000. Создайте массив, состоящий
// из цифр этого числа. Старший разряд числа должен
// располагаться на 0-м индексе массива, младший – на
// последнем. Размер массива должен быть равен количеству цифр.
//
// Решение:
//
Console.WriteLine("Введите число в диапазоне от 1 до 100 000");
int num = Convert.ToInt32(Console.ReadLine());
int arraySize = 0;
int temp = num;

while (temp % 10 > 0)
{
    arraySize++;
    temp /= 10;
}

int[] array = new int[arraySize];

if (num >= 1 && num <= 100000)
{
    temp = num;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = temp % 10;
        temp /= 10;
    }
}
else
{
    Console.WriteLine("Число не подходит!");
    return;
}

for (int i = array.Length - 1; i > -1; i--)
{
    Console.Write(array[i] + " ");
}