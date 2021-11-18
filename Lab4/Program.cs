using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число больше нуля ");
            int N = Convert.ToInt32(Console.ReadLine());
            int Q = 0;

            for (int i = 1; i < N+1; i++)
            {
                Q = Q + 2*i-1;
                Console.WriteLine(Q);
            }

            Console.WriteLine("Квадрат числа {0} равен {1}", N, Q);
            Console.WriteLine("Нажми кнопку");
            Console.ReadKey();
        }
    }
}
