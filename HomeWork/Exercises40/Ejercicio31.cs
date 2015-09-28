using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio31
{
	static void Main(string[] args)
	{
		int num = Basics.getInt ("Número de sonidos del grillo por minuto: ");

		// Ley de Dolbear : grillo de arbol nevado
		double temp = ( (num - 92.0) / 4.7 ) + 50.0;

		Console.WriteLine ("La temperatura es de {0:.#} grados", temp);

		Console.Read ();
	}
}

