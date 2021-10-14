using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, s = 0;
            Console.WriteLine("ingrese n");
            n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                Console.WriteLine( + i);
                s += i;
                i++;
            }
            Console.WriteLine("\n la suma es:" + s);
            if (n != 0)
            {
                Console.WriteLine("el promedio es:" + (double) s/n);
            }
            else
            {
                Console.WriteLine("el promedio no se puede calcular");
            }

        }
    }
}
