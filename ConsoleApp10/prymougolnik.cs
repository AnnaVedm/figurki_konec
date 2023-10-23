using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class prymougolnik
    {
        private double perimetr;
        private double s;
        private double storona;
        private double storona1;

        public void Input()
        {
            Console.Write("Введите сторону прямоугольника a(см): ");
            storona = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону прямоугольника b(см): ");
            storona1 = Convert.ToSingle(Console.ReadLine());

            if (storona <= 0 || storona1 <= 0)
            {
                Console.WriteLine("Такое значение невозможно для стороны прямоугольника. Попробуйте ввести данные ещё раз.");
                Input();
            }
            else
            {
                Perimetr(storona, storona1);
                S1(storona, storona1);
                output(perimetr, s);
            }
        }
        private void Perimetr(double storona, double storona1)
        {
            perimetr = Math.Round(2 * (storona + storona1), 3);
        }
        private void output(double perimetr, double s)
        {
            Console.WriteLine($"\nПериметр прямоугольника = {perimetr} см");
            Console.WriteLine($"\nПлощадь прямоугольника = {s} см^2\n");
        }
        private void S1(double storona, double storona1)
        {
            s = Math.Round(storona * storona1, 3);
        }
    }
}
