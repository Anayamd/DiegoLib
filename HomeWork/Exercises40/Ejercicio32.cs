using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio32
{
	static void Main(string[] args)
	{
		int cantidad = Basics.getInt ("Números a analizar: ");
		int[] array = Basics.getArray (cantidad);

		Console.WriteLine ();
		foreach (int i in array) {
			Console.Write ("{0} ", Math.Pow(i, 3) );
		}

		Console.Read ();
	}
}


