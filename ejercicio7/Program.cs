using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string respuesta = "";           
            {
                do
                {
                    Console.WriteLine("Ingrese 3 numeros:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    num3 = int.Parse(Console.ReadLine());
                    if (num1 == num2 && num1 == num3)
                    {
                        Console.WriteLine("TRIANGULO EQUILATERO");
                    }
                    else
                        if (num1 != num2 && num1 != num3 && num2 != num3)
                    {
                        Console.WriteLine("TIANGULO ESCALENO");
                    }
                    else
                        if (num1 == num2 && num1 == num3 && num2 == num3)
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                    Console.WriteLine("¿Desea continuar?");
                    Console.WriteLine("s-si :  n-no");
                    respuesta = Console.ReadLine();
                } while (respuesta != "n");
            }
        }
    }
}

 