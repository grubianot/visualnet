using System;

namespace AppSuma
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int numero1, numero2, suma;
			string linea;
			Console.WriteLine ("Programa de la suma de dos numeros");
			Console.WriteLine ("Digite numero uno:");
			linea = Console.ReadLine ();
			numero1 = int.Parse (linea);
			Console.WriteLine ("Digite numero Dos:");
			linea = Console.ReadLine ();
			numero2 = int.Parse (linea);


			suma = numero1 + numero2;

			Console.WriteLine ("la suma es :"+suma);
			Console.ReadKey ();

		}
	}
}
