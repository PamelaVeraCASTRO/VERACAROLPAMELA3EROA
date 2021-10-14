using System;

namespace VERACAROLPAMELA3EROA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.Write("El mayor es:" + num1);
            else
                if (num2 > num1)
                Console.Write("El mayor es:" + num2);
        }
    }
}
