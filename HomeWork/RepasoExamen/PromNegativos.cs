using System;
using DiegoLib;

class PromNegativos
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

		int impares = 0;
		int sumImpares = 0;
			
		foreach (int num in numArray) {
			if (num < 0) {
				impares += 1;
				sumImpares += num;
			}
		}

		double prom = sumImpares * 1.0 / impares;

		Console.WriteLine ("\nHay {0} negativos y su valor promedio es: {1:N2}\n", impares, prom);
	}
}

