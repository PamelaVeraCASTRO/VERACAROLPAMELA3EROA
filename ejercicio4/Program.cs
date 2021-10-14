using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            Double num;
            do
            {
                Console.WriteLine("Ingrese un  numero diferente de 0 o entero el programa acabara");
                Console.WriteLine("Ingrese un numero decimal");
                num = Double.Parse(Console.ReadLine());
                if (num!<=0)
                    Console.WriteLine(num);
            } while (num<0);
        }
    }
}
