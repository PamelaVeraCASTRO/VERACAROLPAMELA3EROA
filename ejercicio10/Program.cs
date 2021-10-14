using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)

        {
            int num,factorial=1;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
                Console.Write(i + "*");
            }
            Console.WriteLine("EL FACTORIAL DE:" + num + "es"+factorial);
        }
    }
}
