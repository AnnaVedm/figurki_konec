using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class square
    {
        private double perimetr;
        private double s;
        private double storona;

        private void Perimetr(double storona)
        {
            perimetr = Math.Round(4 * storona, 3);
        }
        public void input()
        {
            Console.Write("Введите сторону квадрата a(см): ");
            storona = Convert.ToSingle(Console.ReadLine());
            if (storona <= 0)
            {
                Console.WriteLine("Такое значение невозможно для стороны квадрата. Попробуйте ввести данные ещё раз.");
                input();
            }
            else
            {
                Perimetr(storona);
                S(storona, s);
                output(perimetr, s);
            }
        }
        private void output(double perimetr, double s)
        {
            Console.WriteLine($"\nПериметр квадрата = {perimetr} см");
            Console.WriteLine($"\nПлощадь квадрата = {s} см^2\n");
        }
        private void S(double storona, double s)
        {
            s = Math.Round(storona * storona, 3);
        }
    }
}
