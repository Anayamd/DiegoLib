using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;

class Ejercicio17
{
	static void Main(string[] args)
	{
		int cantidad;

		do {
			cantidad = Basics.getInt("Ingresa la cantidad de números a analizar: ");
		} while (cantidad < 1);

		Console.WriteLine ();

		int[] numbers = Basics.getArray (cantidad);
		int pares = 0;
		int impares = 0;
		int positivos = 0;
		int negativos = 0;

		foreach (int num in numbers) {
			if (num == 0) {
				continue;
			}
			if (num%2 == 0) {
				pares++;
			} else {
				impares++;
			}
			if (num>0) {
				positivos++;
			}
			if (num<0) {
				negativos++;
			}
		}

		Console.WriteLine ("\n\nPares:\t\t{0}\nImpares:\t{1}\nPositivos:\t{2}\nNegativos:\t{3}", pares, impares, positivos, negativos);

		Console.Read();
	}
}
