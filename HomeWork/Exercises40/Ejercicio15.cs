using DiegoLib;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio15
{
	static void Main(string[] args)
	{
		string[] nums = {"cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"};
		int num;

		do {
			num = Basics.getInt ("Ingresa un número entre 0 y 9: ");
		} while (num < 0 || num > 9);

		Console.WriteLine ("\nEl número {0} se escribe '{1}'", num, nums[num]);

		Console.Read();
	}
}
