using System;
using DiegoLib;

class Ejercicio1
{
	public static void Main (string[] args)
	{
		int size;
		do {
			size = Basics.getInt ("Ingresa un número n>0: ");
		} while (size <= 0);

		Console.WriteLine ();
		string simbol;
		do {
			simbol = Basics.getString("Ingresa un símbolo: ");
		} while (simbol != "+" && simbol != "-" && simbol != "*" && simbol != "/");

		//Imprimimos la primera parte, osea el header
		Console.Write ("\n " + simbol + " | ");
		for (int i = 0; i <= size; i++) {
			Console.Write ("{0,4} ", i);
		}
		Console.WriteLine ();
		Basics.printd ("-", size*6);
		Console.WriteLine ();

		//Imprimimos la tabla
		for (int i = 0; i <= size; i++) {
			Console.Write ("{0,2} | ", i);
			for (int x = 0; x <= size ; x++) {
				if (simbol == "+") {
					Console.Write ("{0,4} ", i+x);
				} else if (simbol == "-") {
					Console.Write ("{0,4} ", x-i);
				} else if (simbol == "*") {
					Console.Write ("{0,4} ", i*x);
				} else {
					if (i == 0) {
						Console.Write ("{0,4} ", null );
					} else {
						Console.Write ("{0,4:#.#} ", (x * 1.0 / i) );
					}
				}
			}
			Console.WriteLine ();
		}

		Console.WriteLine ();
	}
}
