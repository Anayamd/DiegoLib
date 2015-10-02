using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio39
{
	public static bool isSquare( double[] array, double n )
	{
		foreach (var i in array) {
			if (i!=n) {
				return false;
			}
		}
		return true;
	}

	static void Main(string[] args)
	{
		double[] lados = new double[4];

		for (int i = 0; i < 4; i++) {
			lados[i] = Basics.getDouble( "Ingresa el lado " + (i+1) + ": " );
		}

		double n = lados [0];

		if (isSquare(lados, n)) {
			Console.WriteLine ("\nSe forma un cuadrado :)");
		} else {
			Console.WriteLine ("\nSe forma algo diferente a un cuadrado");
		}

		Console.Read ();
	}
}


