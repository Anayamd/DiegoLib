using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;

class Ejercicio36
{
	static void Main(string[] args)
	{
		int cantidad = Basics.getInt ("Cantidad de números: ");
		int[] array = Basics.getArray (cantidad);

		Console.WriteLine ("\nMínimo = {0}\nMáximo = {1}", array.Min(), array.Max());

		Console.Read ();
	}
}


