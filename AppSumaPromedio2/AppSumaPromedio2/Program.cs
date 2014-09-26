using System;

namespace AppSumaPromedio2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1, num2, num3, num4, suma, promedio;
			Console.WriteLine ("Calcula su suma y su Promedio");
			Console.WriteLine ("Digite numero 1:");
			num1 = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Digite numero 2:");
			num2 = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Digite numero 3:");
			num3 = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Digite numero 4:");
			num4 = double.Parse (Console.ReadLine ());

			suma = num1 + num2 + num3 + num4;

			promedio = suma / 4;

			Console.WriteLine ("la suma de los numero es:"+suma+ "y el promedio es:"+promedio);
			Console.ReadKey();

		}
	}
}
