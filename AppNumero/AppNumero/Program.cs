using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ingresar un numero entre uno y cinco en castellano. Luego mostrar
             * en formato numero. Si se ingresa un valor fuera de dicho rango 
             * mostrar un mensaje indicando tal situacion.
           */

            String numero, num;

            Console.WriteLine("Programa que pasa de numero a caracter");

            numero = Console.ReadLine();
            num = numero;

            switch (num)
            {
                case "1":
                    Console.WriteLine("UNO");
                    break;

                case "2":
                    Console.WriteLine("DOS");
                    break;

                case "3":
                    Console.WriteLine("TRES");
                    break;

                case "4":
                    Console.WriteLine("CUATRO");
                    break;

                case "5":
                    Console.WriteLine("CINCO");
                    break;
            }

            Console.ReadKey();

        }
    }
}
