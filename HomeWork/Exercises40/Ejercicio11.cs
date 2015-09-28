using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio11
{
	static void Main(string[] args)
	{
		int cantidad = Basics.getInt ("Cantidad de números a sumar: ");
		int[] array = Basics.getArray (cantidad);
		int sum = 0;

		foreach (int num in array) {
			if (num > 0) {
				sum += num;
			}
		}

		Console.WriteLine("\nLa suma de los números naturales dados, es: {0}", sum);

		Console.Read();
	}
}
