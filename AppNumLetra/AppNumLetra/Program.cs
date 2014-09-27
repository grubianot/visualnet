using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumLetra
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("Programa que pasa un caracter a numero");
            Console.WriteLine("Digite un numero de el 1 al 5 en letra");
            numero = Console.ReadLine();
           
            switch (numero)
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

                default:
                    Console.WriteLine("NUMERO FUERA DE RANGO");
                    break;

            }
            Console.ReadKey();
        }
    }
}
