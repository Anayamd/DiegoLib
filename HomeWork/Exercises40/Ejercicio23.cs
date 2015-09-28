using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio23
{
	static double _FEET = 3.28084;
	static double _INCHES = 39.3701;

	public static void conversion(double metros)
	{
		Console.WriteLine ("\n {0,-8} metros\n{1,-9} pies\n{2,-9} pulgadas", metros, metros*_FEET, metros*_INCHES);
	}

	static void Main(string[] args)
	{
		int cantidad = Basics.getInt ("Cantidad de números a analizar: ");
		int[] array = Basics.getArray (cantidad, "Metros ");

		foreach (int i in array) {
			conversion (i);
		}

		Console.Read ();
	}
}

