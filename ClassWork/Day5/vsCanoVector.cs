using System;
using System.Linq;
using DiegoLib;

class Vector
{
	public static void Main (string[] args)
	{
		int [] array = new int[10];
		for (int i = 0; i < 10; i++) {
			array[i] = Basics.getInt("Ingresa el valor " + (i+1) + ": ");
		}

		int biggestNum = array.Max();

		Console.WriteLine ("\nEl número más grande es: {0}\tEn la posición: {1}", biggestNum, array.ToList().IndexOf(biggestNum) + 1);

		Console.Read ();
	}
}


