using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            float Q;
            int nechet = 0;
            int chet = 0;

            Console.WriteLine("Введите числа последовательности (0=STOP): ");

            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                Q = (N % 2);

                if (Q != 0)
                {
                    nechet++;
                }

                else
                {
                    chet++;
                }

            } while (N != 0);

            if (chet == nechet)
            {
                Console.WriteLine("Чет и нечет - одинаково");
            }
            else
            {
                if (chet > nechet)
                {
                    Console.WriteLine("Четных больше");
                }
                else
                {
                    Console.WriteLine("Нечетных больше");
                }
            }

            Console.WriteLine("Нажми кнопку");
            Console.ReadKey();
        }
    }
}
