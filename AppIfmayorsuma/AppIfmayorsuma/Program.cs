using System;

namespace AppIfmayorsuma
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1, num2, suma, resta, producto, division;
			Console.WriteLine (" Cual es mayor");

			Console.WriteLine ("Dgite numero 1:");
			num1 = int.Parse (Console.ReadLine());

			Console.WriteLine ("Dgite numero 2:");
			num2 = int.Parse (Console.ReadLine());

			if (num1 > num2)
			 {
				suma = num1 + num2;
				resta = num1 + num2;

				Console.WriteLine ("la suma de el numero es:" + suma + "la resta del numero es:" + resta);
			}
			 else
			 {
				producto = num1 * num2;
				division = num1 / num2;
				Console.WriteLine ("El producto de el numero es:" + producto + "la division del numer0 es:" + division);
			}
					Console.ReadKey();
			}
					



		}
	}

