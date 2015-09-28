using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio27
{
	static void Main(string[] args)
	{
		int tBase = Basics.getInt ("Ingresa la base del triángulo: ");
		int tHeight = Basics.getInt ("Ingresa la altura del triángulo: ");

		Console.WriteLine ("\nÁrea del triángulo: {0}", tBase * tHeight * 1.0 / 2);

		Console.Read ();
	}
}

