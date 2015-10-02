using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio40
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
		int[] primes = new int[cantidad];
		int pos = 0;
		int temp;
		int sum = 0;

		do {
			do {
				temp = Basics.getInt("Ingresa el primo #" + (pos+1) + ": ");
			} while (!isPrime(temp));
			primes[pos] = temp;
			pos++;
		} while (pos < cantidad);

		foreach (int i in primes) {
			sum += i;
		}

		Console.WriteLine ("\nPromedio de los primos: {0}", sum * 1.0/cantidad);

		Console.Read ();
	}
}

