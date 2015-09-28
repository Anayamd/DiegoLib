using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio20
{
	static void Main(string[] args)
	{
		Console.WriteLine ("Múltiplos de 5");
		Basics.printd ("-", 70);
		Console.WriteLine ();

		for (int i = 5; i <= 1000; i+=5) {
			Console.Write ("{0} ", i);
		}

		Console.Read ();
	}
}
