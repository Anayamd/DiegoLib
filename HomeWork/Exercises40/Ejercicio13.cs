using DiegoLib;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio13
{
	static void Main(string[] args)
	{
		double a = Basics.getDouble ("Ingresa un número 'a': ");
		double b = Basics.getDouble ("Ingresa un número 'b': ");

		double mayor = a*a;
		double menor = b*b*b;

		Basics.printd ("-", 50);

		if (mayor > menor) {
			Console.WriteLine ("\n{0}x{0,-3} > {2,3}x{2}x{2}\n\n{1,-5} > {3,5}", a, mayor, b, menor);
		} else {
			Console.WriteLine ("\n{0}x{0,-3} < {2,3}x{2}x{2}\n\n{1,-5} < {3,5}", a, mayor, b, menor);
		}

		Console.Read();
	}
}


