using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio21
{
	static void Main(string[] args)
	{
		int a = Basics.getInt ("Ingresa un número (a): ");
		int b = Basics.getInt ("Ingresa un número (b): ");

		if (a > b) {
			int temp = b;
			b = a;
			a = temp;
		}

		int[] pares = new int[b-a];
		int pos = 0;

		for (int i = a; i <= b; i++) {
			if (i%2 == 0) {
				pares [pos] = i;
				pos++;
			}
		}

		pares = pares.Where(val => val != 0).ToArray();

		Console.WriteLine ();

		for (int i = 0; i < pares.Length; i++) {
			if ((i+1) == pares.Length) {
				Console.Write ("{0} = {1}", pares[i], pares.Sum());
				break;
			}
			Console.Write ("{0} + ", pares[i]);
		}

		Console.WriteLine ();

		for (int i = 0; i < pares.Length; i++) {
			if ((i+1) == pares.Length) {
				Console.Write ("{0} = {1}", pares[i], pares.Aggregate((x,y) => x*y) );
				break;
			}
			Console.Write ("{0} * ", pares[i]);
		}


		Console.Read ();
	}
}

