using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class piramida
    {
        private double perimetr;
        private double s;
        private double storona_a;
        private double osnova_n;
        private double vysota_h;
        private double obem_fig;
        public void input()
        {
            Console.Write("Введите длину стороны основания пирамиды a(см): ");
            storona_a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите число сторон основания n(от 3 до 5): ");
            osnova_n = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите высоту пирамиды h(см): ");
            vysota_h = Convert.ToSingle(Console.ReadLine());

            if ((storona_a <= 0 || osnova_n <= 0 || vysota_h <= 0) || osnova_n < 3)
            {
                Console.WriteLine("\nТакая пирамида не существует! Попробуйте ввести данные ещё раз\n");
                input();
            }
            if (osnova_n > 5)
            {
                while (osnova_n > 5)
                {
                    Console.Write("\nВведите количество сторон соответствующее критерию (от 3 до 5):\n");
                    osnova_n = Convert.ToSingle(Console.ReadLine());
                    Console.Clear();
                }
            }
            if (osnova_n == 3)
            {
                Console.WriteLine("\nВаша пирамида имеет в основании треугольник!\n");
            }
            else if (osnova_n == 4)
            {
                Console.WriteLine("\nВаша пирамида имеет в основании квадрат!\n");
            }
            else if (osnova_n > 4)
            {
                Console.WriteLine("\nВаша пирамида имеет в основании многоугольник!\n");
            }
            S(storona_a, osnova_n, vysota_h);
            p(s, storona_a, osnova_n);
            obem(perimetr, s, vysota_h);
            output(s, perimetr, obem_fig);
        }
        private void S(double storona_a, double osnova_n, double vysota_h)
        {
            s = Math.Round(((storona_a * osnova_n) / 2) * ((storona_a / (2 * Math.Tan(180 / osnova_n)) + Math.Sqrt((vysota_h * vysota_h) + Math.Pow(storona_a / (2 * Math.Tan(180 / osnova_n)), 2)))), 3);
        }
        private void p(double s, double storona_a, double osnova_n)
        {
            perimetr = Math.Round(storona_a * (osnova_n * 2), 3);
        }
        private void obem(double perimetr, double s, double vysota_h)
        {
            if (osnova_n == 3)
            {
                obem_fig = Math.Round(((Math.Pow(storona_a, 2) * Math.Sqrt(3)) / 4 * vysota_h) / 3, 3);
            }
            else if (osnova_n == 4)
            {
                obem_fig = Math.Round((Math.Pow(storona_a, 2) * vysota_h) / 3, 3);
            }
        }
        private void output(double s, double perimetr, double obem_fig)
        {
            Console.WriteLine($"\nПериметр пирамиды = {perimetr} см");
            Console.WriteLine($"\nПлощадь пирамиды = {s} см^2\n");
            Console.WriteLine($"Объем пирамиды = {obem_fig} см^3\n");
        }
    }
}
