using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio33
{
	static int pos = -1;

	public static bool collatz(BigInteger n, BigInteger[] array)
	{
		if (n==1) {
			array[++pos] = n;
			return true;
		}
		if (n%2 != 0) {
			array[++pos] = n;
			return collatz((3 * n) + 1, array);
		}
		else {
			array[++pos] = n;
			return collatz(n/2, array);
		}
	}

	static void Main(string[] args)
	{
		BigInteger[] nums = new BigInteger[100000000];
		Console.Write ("Número a analizar: ");
		BigInteger number = BigInteger.Parse(Console.ReadLine());

		collatz (number, nums);

		nums = nums.Where(val => val != 0).ToArray();

		foreach (BigInteger i in nums) {
			Console.Write ("{0} ", i);
		}

		Console.WriteLine ("\n\nSTEPS = {0}", nums.Length - 1);

		Console.Read ();
	}
}


