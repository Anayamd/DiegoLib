using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio34
{
	static void Main(string[] args)
	{
		int[] localidad = Basics.getArray (5, "Precio localidad");
		Console.WriteLine ();
		int[] vendidos = Basics.getArray (5, "Boletos vendidos localidad");
		Console.WriteLine ();
		int sum = 0;

		for (int i = 0; i < 5; i++) {
			Console.WriteLine ("Localidad {0} vendió ${1,7:N}", i+1, vendidos[i]*localidad[i]);
			sum += vendidos [i] * localidad [i];
		}

		Console.WriteLine ("\nCantidad recaudada: {0}", sum);

		Console.Read ();
	}
}


