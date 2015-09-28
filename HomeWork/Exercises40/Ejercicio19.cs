using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio19
{
	public static BigInteger Factorial(BigInteger bn)
	{
		if (bn <= 0) {
			return 1;
		}
		return bn * Factorial (bn - 1);
	}
	
	static void Main(string[] args)
	{
		long value = Basics.getLong ("Ingresa un número: ");

		BigInteger number = new BigInteger (value);
		number = Factorial (number);

		Console.WriteLine (number.ToString ("N0"));

		Console.Read ();
	}
}