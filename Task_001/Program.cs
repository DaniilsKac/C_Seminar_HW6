﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите значения: ");
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count++;
}

Console.WriteLine(count);