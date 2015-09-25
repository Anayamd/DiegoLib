using System;
using DiegoLib;

class Ejercicio6
{
	public static void Main (string[] args)
	{
		int size = Basics.getInt("Ingrese la cantidad de números a evaluar: ");
		int[] array = new int[size];
		Console.WriteLine ();

		for (int i = 0; i < size; i++) {
			array [i] = Basics.getInt ("Ingrese el número " + (i+1) + " : ");
		}
		Console.WriteLine ();

		for (int i = 1; i < size; i+=2) {
			Console.WriteLine ("{0,-2}*{0,2} = {1,5}", array[i], array[i]*array[i]);
		}
		Console.WriteLine ();

	}
}


