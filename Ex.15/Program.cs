﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}