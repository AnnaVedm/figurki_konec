﻿using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Фигурки
{
    class Program
    {
        static void Main(string[] args)
        {
            square schet = new square();
            prymougolnik schet1 = new prymougolnik();
            krug schet2 = new krug();
            triangle schet3 = new triangle();
            piramida schet4 = new piramida();
            konus schet5 = new konus();

            while (true)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1. Квадрат");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Круг");
                Console.WriteLine("4. Треугольник");
                Console.WriteLine("5. Пирамида");
                Console.WriteLine("6. Конус");
                Console.WriteLine("7. Выйти");

                int vybory = int.Parse(Console.ReadLine());

                switch (vybory)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали квадрат: ");
                        schet.input();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали прямоугольник: ");
                        schet1.Input();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали круг: ");
                        schet2.input();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали треугольник: ");
                        schet3.input();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали пирамиду: ");
                        schet4.input();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали конус: ");
                        schet5.input();
                        break;
                    case 7:
                        Console.WriteLine("Выход.");
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }
}
