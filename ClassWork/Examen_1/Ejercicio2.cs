using System;
using DiegoLib;

class Ejercicio2
{
	public static void Main (string[] args)
	{
		int inf = Basics.getInt ("Ingresa un número: ");
		int sup = Basics.getInt ("\nIngresa otro número: ");
		Console.WriteLine ();

		if (inf < 0) {
			inf *= -1;
		}
		if (sup < 0) {
			sup *= -1;
		}

		if (inf > sup) {
			int temp = inf;
			inf = sup;
			sup = temp;
		}

		Basics.printd ("-", 50);
		Console.WriteLine ("\nLos múltiplos de 2 - 3 en rango ({0},{1}) son:\n", inf, sup);

		int[] mult2 = new int[sup-inf];
		int[] mult3 = new int[sup-inf];
		int contador2 = 0;
		int contador3 = 0;

		for (int i = inf; i <= sup; i++) {
			if (i%2 == 0) {
				mult2[contador2] = i;
				contador2++;
			}
			if (i%3 == 0) {
				mult3[contador3] = i;
				contador3++;
			}
		}

		//IMPRIMIMOS ARRAYS
		foreach (int num in mult2) {
			if (num != 0) {
				Console.Write ("{0} ", num);
			}
		}
		Console.Write ("- ");
		foreach (int num in mult3) {
			if (num != 0) {
				Console.Write ("{0} ", num);
			}
		}
		Console.WriteLine ("\n");
	}
}

