using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class konus
    {
        private double perimetr;
        private double s;
        private double radius;
        private double l;
        private double vysota_h;
        private double obem_fig;

        public void input()
        {
            Console.Clear();
            //Console.WriteLine("ВЫЧИСЛЕНИЕ ПЛОЩАДИ, ОБЪЕМА И ПЕРИМЕТРА КОНУСА");
            Console.Write("Введите радиус (основания) конуса: ");
            radius = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите образующую конуса (отрезок от вершины конуса до границы его основания) l (см): ");
            l = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите высоту конуса (отрезок от вершины конуса до центра его основания) h (см): ");
            vysota_h = Convert.ToSingle(Console.ReadLine());

            if (radius <= 0 || l <= 0 || vysota_h <= 0)
            {
                Console.WriteLine("\nТакой конус не существует! Попробуйте ввести данные ещё раз\n");
                input();
            }
            S(radius, l, vysota_h);
            P(radius, l);
            obem_figur(radius, l, vysota_h);
            output(perimetr, s, obem_fig);
        }
        private void S(double radius, double l, double vysota_h)
        {
            s = Math.Round(Math.PI * radius * l + Math.PI * Math.Pow(radius, 2), 3);
        }
        private void P(double radius, double l)
        {
            perimetr = Math.Round(radius * Math.PI + l * 2, 3);
        }
        private void obem_figur(double radius, double l, double vysota_h)
        {
            obem_fig = Math.Round((Math.PI * Math.Pow(radius, 2) * vysota_h) / 3, 3);
        }
        private void output(double s, double perimetr, double obem_fig)
        {
            Console.WriteLine($"\nПериметр конуса = {perimetr} см");
            Console.WriteLine($"\nПлощадь конуса = {s} см^2\n");
            Console.WriteLine($"Объем конуса = {obem_fig} см^3\n");
        }
    }
}
