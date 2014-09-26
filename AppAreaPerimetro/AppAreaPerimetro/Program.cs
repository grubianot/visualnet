using System;

namespace AppAreaPerimetro
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro; 
			Console.WriteLine ("Calculemos el  Area y Perimetro de un Cuadrado");
			Console.WriteLine ("Digite lado:");
			lado = float.Parse (Console.ReadLine ());
			area = lado * lado;
			Console.WriteLine ("el area del cuadrado es:"+area);
			perimetro = 4 * lado;
			Console.WriteLine ("el perimero del cuadadro es:"+perimetro);

			Console.ReadKey ();
		}
	}
}
