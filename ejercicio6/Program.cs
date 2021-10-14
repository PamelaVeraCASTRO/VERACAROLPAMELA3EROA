using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int  num1,suma=0;
            do
            {
                Console.WriteLine("Introduzca un numero:");
                num1 = int.Parse(Console.ReadLine());
                suma = suma + num1;
            } while (num1 != 0);
            Console.WriteLine("EL RESULTADO DE LA SUMA ES:" + suma);
        }

        }
    }


