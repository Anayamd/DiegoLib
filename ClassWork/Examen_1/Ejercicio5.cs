using System;
using DiegoLib;

class Ejercicio5
{
	public static void Main (string[] args)
	{
		int size = Basics.getInt("Ingrese la cantidad de números a evaluar: ");
		int[] array = new int[size];
		Console.WriteLine ();

		for (int i = 0; i < size; i++) {
			array [i] = Basics.getInt ("Ingrese el número " + (i+1) + " : ");
		}

		int cantidad = 0;
		int sum = 0;

		foreach (int num in array) {
			if (num%2!=0 && num!=0) {
				sum += num;
				cantidad++;
			}
		}

		double promedio = sum * 1.0 / cantidad;

		Console.WriteLine ("\nEl promedio de los impares es: {0:####.##}\nHay {1} impares\n", promedio, cantidad);
	}
}

