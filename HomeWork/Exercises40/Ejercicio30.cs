using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio30
{
	static void Main(string[] args)
	{
		double radio = Basics.getDouble ("Ingresa el radio del cilindro: ");
		double altura = Basics.getDouble ("Ingresa la altura del cilindro: ");

		double volume = Math.Pow (radio, 2) * Math.PI * altura;
		double area = (2 * Math.PI * radio * altura) + (2 * Math.Pow (radio, 2) * Math.PI);

		Console.WriteLine ("\nÁrea de: {0:.##}\nVolumen: {1:.##}", area, volume);

		Console.Read ();
	}
}

