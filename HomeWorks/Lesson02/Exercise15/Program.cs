﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
int day_num = int.Parse(Console.ReadLine()!);

if (day_num == 6 || day_num == 7)
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Нет, это не выходной день.");
}