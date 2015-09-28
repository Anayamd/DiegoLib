using DiegoLib;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio14
{
	static void Main(string[] args)
	{
		int cantidad = Basics.getByte ("Cantidad de notas: ");
		Console.WriteLine ();
		int[] notas = Basics.getArray (cantidad, "Ingresa la nota");

		int aproved = 0;
		int failed = 0;
		double[] sum = new double[3];

		foreach (int note in notas) {
			sum[0] += note;
			if (note > 5) {
				sum [1] += note;
				aproved++;
				continue;
			}
			sum [2] += note;
			failed++;
		}
		sum [0] = sum [0] / cantidad;
		sum [1] = sum [1] / aproved;
		sum [2] = sum [2] / failed;

		Basics.printd ("_", 70);
		Console.WriteLine ("\n\nAprovadas: \t\t{0,5}\nReprovadas: \t\t{1,5}\n\nPromedio Aprobadas: \t{2,5:.##}\nPromedio Reprobadas: \t{3,5:.##}\nPromedio Total: \t{4,5:.##}", aproved, failed, sum[1], sum[2], sum[0]);

		Console.Read();
	}
}



