using DiegoLib;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio12
{
	static void Main(string[] args)
	{
		int cantidad = Basics.getInt ("Número de empleados: ");

		double[,] empleados = new double[cantidad, 3];

		for (int i = 0; i < cantidad; i++)
		{
			Console.WriteLine ("\nEmpleado {0}", i+1);
			empleados [i,0] = Basics.getInt ("Horas trabajadas: ");
			empleados [i,1] = Basics.getInt ("Tarifa : ");

			if (empleados [i,0] > 40)
			{
				empleados [i,2] = 40 * empleados [i,1] + (empleados [i,0]-40)*empleados [i,1]*1.5;
			}
			else
			{
				empleados [i,2] = empleados [i,0] * empleados [i,1];
			}

		}

		Console.WriteLine ();

		for (int i = 0; i < cantidad; i++) {
			Console.WriteLine ("Empleado {0}\tPago de: {1,-5}", i+1, empleados[i,2]);
		}

		// Current path
		string appPath = Directory.GetCurrentDirectory();

		Console.Read();
	}
}

