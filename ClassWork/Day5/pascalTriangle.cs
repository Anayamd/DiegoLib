using System;
using DiegoLib;

class MainClass
{
	public static int binomialCoefficient(int n, int k)
	{
		if (n==k || k==0) {
			return 1;
		}
		return binomialCoefficient(n-1, k-1) + binomialCoefficient(n-1, k);
	}

	public static void Main (string[] args)
	{
		int alto;
		do {
			alto = Basics.getInt ("Ingresa la altura del triángulo: ");
		} while (alto < 1);
		Console.WriteLine ();

		int temp;
		int espacios;

		for (int y = 0; y < alto; y++) {
			espacios = y * 2 + 1;

			// Espacios
			if (alto%2==0) {
				Basics.printd( "   ", alto/2 - y/2 );
			}
			else {
				if (y%2==1) {
					Basics.printd( "   ", alto/2 - y/2 - 1 );
				} else {
					Basics.printd( "   ", alto/2 - y/2 );
				}
			}

			Basics.printd( "   ", (alto-y)/2 );

			for (int i = 0; i < y+1; i++) {
				temp = binomialCoefficient(y,i);
				Console.Write ("  {0,2}  ", temp);
			}
			
			Console.WriteLine ();
		}

		Console.Read ();
	}
}