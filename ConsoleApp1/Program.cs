﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введи свое имя:");
string name = Console.ReadLine();
Console.WriteLine("В каком году ты родился?");
int year = int.Parse(Console.ReadLine());
Console.WriteLine($"Сейчас тебе {2022 - year} лет");
