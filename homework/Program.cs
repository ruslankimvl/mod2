using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {

            task2();
        }

       static public void task1()
        {
            Console.WriteLine("Введите текст: ");
            char str = ' ';
            int space = 0;
            while (str != '.')
            {
                str = Console.ReadKey().KeyChar;
                if (str == ' ')
                    space++;
            }

            Console.WriteLine("Количество пробелов: {0}", space);
        }

        static public void task2()
        {
            Console.WriteLine("Введите шестизначное число");
            Int32 number = Convert.ToInt32(Console.ReadLine());
            int num1 = number / 100000 % 10;
            int num2 = number / 10000 % 10;
            int num3 = number / 1000 % 10;
            int num4 = number / 100 % 10;
            int num5 = number / 10 % 10;
            int num6 = number / 1%10;
            if (num1 + num2 + num3 == num4 + num5 + num6)
                Console.WriteLine("Ваш билет счастливый");
            else
                Console.WriteLine("Ваш билет не счастливый");
        }
        
        public void task3()
        {
            Int32 number = Convert.ToInt32(Console.ReadLine());
            int meters = number / 100;
            Console.WriteLine("Полных метров: {0}", meters);
        }
        public void task4()
        {
            Int32 number = Convert.ToInt32(Console.ReadLine());
            int weeks = number / 7;
            Console.WriteLine("Полных недель: {0}", weeks);
        }
        public void task5()
        {
            Int32 x = Convert.ToInt32(Console.ReadLine());
            int y = 7 * (x * x) - 3 * x + 6;
            Console.WriteLine("Ответ: {0}", y);
        }

       
        public void task6()
        {
            Int32 a = Convert.ToInt32(Console.ReadLine());
            int x = 12 * (a * a) + 7 * a - 16;
            Console.WriteLine("Ответ: {0}", x);

        }

        public void task7()
        {
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Int32 b = Convert.ToInt32(Console.ReadLine());
            int avg = a * b / 2;
            double geom = Math.Sqrt(a * b);
            Console.WriteLine("Avg: {0}", avg);
            Console.WriteLine("Geom: {0}", geom);
        }

        public void task8()
        {
            Int32 m = Convert.ToInt32(Console.ReadLine());
            Int32 v = Convert.ToInt32(Console.ReadLine());
            int p = m / v;
            Console.WriteLine("Плотность: {0}", p);
        }
        public void task9()
        {
            Int32 a = Convert.ToInt32(Console.ReadLine());
            int p = a * 4;
            Console.Write("Периметр квадрата: {0]", p);
        }
        public void task10()
        {
            Int32 r = Convert.ToInt32(Console.ReadLine());
            int d = r * 2;
            Console.Write("Диаметр окружности: {0]", d);
        }


    }
}
