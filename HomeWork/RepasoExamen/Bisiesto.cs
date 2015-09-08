using System;
using DiegoLib;

class Bisiesto
{
	public static void Main (string[] args)
	{
		int num = Basics.getInt ("Ingresa un año: ");

		if (num%4 == 0 && (num%100 != 0 || num%400 == 0)) {
			Console.WriteLine ("\nEl año: {0} es bisiesto\n", num);
		} else {
			Console.WriteLine ("\nEl año: {0} NO es bisiesto\n", num);
		}
	}
}

