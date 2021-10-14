using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5,suma;
            Console.WriteLine("Ingrese 5 numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            suma = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("LA SUMA DE LOS NUMEROS:" + num1 + "," + num2 + "," + num3 + "," + num4 + "," + num5 + "es:" + suma);
        }
    }
}
