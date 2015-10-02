using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio37
{
	public static bool isPrime(int n)
	{
		if (n < 2)
		{
			return false;
		}
		if (n == 2)
		{
			return true;
		}
		for (int i = 2; i < n/2+1; i++)
		{
			if (n%i == 0)
			{
				return false;
			}
		}
		return true;
	}

	static void Main(string[] args)
	{
		int cantidad = Basics.getInt ("Cantidad de números a analizar: ");
		int[] array = Basics.getArray (cantidad);

		//Pares = 0, Impares = 1, Primos = 2
		int[] tipo = {0, 0, 0};

		foreach (int i in array) {
			if (i%2 == 0) {
				tipo[0]++;
			} else {
				tipo[1]++;
			}
			if (isPrime(i)) {
				tipo[2]++;
			}
		}

		Console.WriteLine ("\nPares = {0}\nImpares = {1}\nPrimos = {2}", tipo[0], tipo[1], tipo[2] );

		Console.Read ();
	}
}
