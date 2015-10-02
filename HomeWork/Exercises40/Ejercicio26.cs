using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio26
{
	static void Main(string[] args)
	{
		BigInteger[] fibNums = new BigInteger[301];
		fibNums[0] = 0;
		fibNums[1] = 1;

		int pos = 2;

		while (pos < fibNums.Length) {
			fibNums[pos] += fibNums[pos-1] + fibNums[pos-2];
			pos++;
		}

		foreach (var i in fibNums) {
			Console.Write ("{0} ", i);
		}

		Console.WriteLine ("\n\nEl número de fibonacci posición #300");
		Console.WriteLine ("\nSi la secuencia empieza 0, 1, 1, 2, ...\n{0}", fibNums[fibNums.Length - 2].ToString ("N0"));
		Console.WriteLine ("\nSi la secuencia empieza 1, 1, 2, 3, ...\n{0}", fibNums[fibNums.Length - 1].ToString ("N0"));

		Console.Read ();
	}
}

