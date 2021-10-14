using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta1, conta2, conta3;
            Console.WriteLine("Ingrese 3 numeros");
            conta1=int.Parse(Console.ReadLine());
            conta2 = int.Parse(Console.ReadLine());
            conta3 = int.Parse(Console.ReadLine());
            if (conta1 > conta2 && conta1 > conta3) {
                Console.WriteLine("El numero mayor entre" + conta1 +   ","    +conta2 +     ","    +conta3 + "es:" + conta1);
            }else 
                if (conta2>conta1 && conta2 > conta3)
            {
                Console.WriteLine("El numero mayor entre" + conta1 + "," +conta2 + "," +conta3 + "es:" + conta2);
            }else 
                if (conta3>conta1  &&   conta3>conta2){
                Console.WriteLine("El numero mayor entre " + conta1 + "," +conta2 + "," +conta3 +  "es:" + conta3);

            }
        }
    }
}
