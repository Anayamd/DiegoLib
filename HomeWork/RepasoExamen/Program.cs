using System;
using DiegoLib;

class ParesImpares
{
	public static void Main (string[] args)
	{
		int size;

		do {
			size = Basics.getInt ("Cantidad de números por analizar: ");
		} while (size < 1);

		int [] numArray = new int[size];

		for (int i = 0; i < size; i++) {
			numArray [i] = Basics.getInt ("Ingresa el número " + (i+1) + ": ");
		}

		int pares = 0;
		int impares = 0;

		foreach (int num in numArray) {
			if (num%2 == 0) {
				pares += 1;
			} else {
				impares += 1;
			}
		}

		Console.WriteLine ("\nEn esos {0} números, hay {1} pares y {2} impares\n", numArray.Length, pares, impares);
	}
}