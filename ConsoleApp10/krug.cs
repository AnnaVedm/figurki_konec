using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class krug
    {
        private double perimetr;
        private double s;
        private double radius;

        public void input() //запись данных о круге
        {
            Console.Write("Введите радиус круга r(см): ");
            radius = Convert.ToSingle(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Такое значение невозможно для радиуса круга. Попробуйте ввести данные ещё раз.");
                input();
            }
            else
            {
                Perimetr_krug(radius);
                S2(radius);
                output(perimetr, s);
            }
        }
        private void Perimetr_krug(double radius) //расчет длтны окружности
        {
            perimetr = Math.Round(2 * Math.PI * radius, 3);
        }
        private void S2(double radius)
        {
            s = Math.Round(Math.PI * (radius * radius), 3);
        }
        private void output(double s, double perimetr)
        {
            Console.WriteLine($"\nПериметр круга = {perimetr} см");
            Console.WriteLine($"\nПлощадь круга = {s} см^2\n");
        }
    }
}
