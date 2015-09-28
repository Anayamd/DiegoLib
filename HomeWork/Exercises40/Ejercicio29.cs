using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio29
{
	static void Main(string[] args)
	{
		double _costoGas = 14.38;
		double surtido = Basics.getDouble ("Litros surtidos (galones): ");
		double litros = surtido * 3.78541;

		Console.WriteLine ("\nCobrar: {0:.##}", litros * _costoGas );

		Console.Read ();
	}
}

