using System;

namespace ejercico2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
                Console.WriteLine("SU NUMERO ES PAR");
            else
                Console.WriteLine("SU NUMERO ES IMPAR");

        }
    }
}
