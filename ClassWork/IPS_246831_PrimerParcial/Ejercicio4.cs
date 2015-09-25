using System;
using System.Linq;
using DiegoLib;

class Ejercicio4
{
	public static void Main (string[] args)
	{
		int size = Basics.getInt("Ingrese la cantidad de números a evaluar: ");
		int[] array = new int[size];
		Console.WriteLine ();

		for (int i = 0; i < size; i++) {
			array [i] = Basics.getInt ("Ingrese el número " + (i+1) + " : ");
		}

		Console.WriteLine ("\nEl número más grande es {0}\n", array.Max());
	}
}
