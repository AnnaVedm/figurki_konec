using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class triangle
    {
        private double perimetr;
        private double s;
        private double storona_a;
        private double storona_b;
        private double storona_c;
        //private double summa_kvadratov1;//сторон в квадрате
        //private double summa_kvadratov2;//сторон в квадрате
        //private double summa1;//сумма сторон
        //private double summa2;
        //private double summa3;
        private double p;// Полупериметр для формулы герона
        private void Perimetr(double storona_a, double storona_b, double storona_c)
        {
            perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
        }
        private void S3(double storona_a, double storona_b, double storona_c)
        {
            p = (storona_a + storona_b + storona_c) / 2;
            s = Math.Round(Math.Sqrt(p * (p - storona_a) * (p - storona_b) * (p - storona_c)), 3);
        }
        public void input()
        {
            Console.Write("Введите сторону треугольника a(см): ");
            storona_a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону треугольника b(см): ");
            storona_b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону треугольника с(см): ");
            storona_c = Convert.ToSingle(Console.ReadLine());

            if (storona_a <= 0 || storona_b <= 0 || storona_c <= 0)
            {
                Console.WriteLine("Такое значение невозможно для стороны треугольника. Попробуйте ввести данные ещё раз.");
                input();
            }
            else
            {
                //summa_kvadratov1 = (storona_a * storona_a) + (storona_b * storona_b);
                //summa_kvadratov2 = (storona_b * storona_b) + (storona_c * storona_c);
                //summa1 = storona_a + storona_b;
                //summa2 = storona_b + storona_c;
                //summa3 = storona_a + storona_c;

                if ((storona_a + storona_b) <= storona_c || (storona_b + storona_c) <= storona_a || (storona_a + storona_c) <= storona_b)
                {
                    Console.WriteLine("\nТакой треугольник не существует! Попробуйте ввести данные ещё раз\n");
                    input();
                }
                else if (storona_a == storona_b && storona_b == storona_c)
                    Console.WriteLine("\nВаш треугольник равноcторонний!\n");

                else if (storona_a == storona_b || storona_b == storona_c || storona_c == storona_a)
                    Console.WriteLine("\nВаш треугольник равнобедренный!\n");

                else if (storona_a != storona_b || storona_b != storona_c || storona_c != storona_a)
                    Console.WriteLine("\nВаш треугольник разносторонний!\n");

                if ((storona_a * storona_a) + (storona_b * storona_b) == storona_c * storona_c || (storona_b * storona_b) + (storona_c * storona_c) == storona_a * storona_a)
                    Console.WriteLine("\nВаш треугольник прямоугольный!\n");

                Perimetr(storona_a, storona_b, storona_c);
                S3(storona_a, storona_b, storona_c);
                output(perimetr, s);

            }

        }
        private void output(double perimetr, double s)
        {
            Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
            Console.WriteLine($"\nПлощадь треугольника = {s} см^2\n");
        }
    }
}
