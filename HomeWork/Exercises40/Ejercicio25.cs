using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio25
{
	static void Main(string[] args)
	{
		double[] monedas = { .1, .2, .5, 1, 2, 5, 10, 20, 50, 100, 200, 1000 };

		double costo = Basics.getDouble ("Costo del artículo: ");
		double dinero = Basics.getDouble ("Dinero recibido: ");
		double cambio = dinero - costo;

		if (cambio <= 0) {
			Console.WriteLine ("No hay cambio");
		} else {
			double[] dar = new double[50];
			int pos = 0;

			foreach (double moneda in monedas.Reverse()) {
				while (cambio >= moneda) {
					cambio -= moneda;
					dar [pos] = moneda;
					pos++;
				}
			}

			dar = dar.Where (val => val != 0).ToArray();

			Console.WriteLine ();

			foreach (double item in dar) {
				if (item >= 20) {
					Console.WriteLine ("Entregar billete de: {0}", item);
				} else {
					Console.WriteLine ("Entregar moneda de: {0}", item);
				}
			}

			Console.WriteLine ("\nCambio total de: {0}", dar.Sum());
		}

		Console.Read ();
	}
}

