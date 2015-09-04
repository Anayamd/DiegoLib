using System;
using System.Linq;
using DiegoLib;

class EjercicioPDF_5
{
	public static void Main()
	{
		string frase = Basics.getString("Ingrese una frase: ");

		for (int i = frase.Length -1; i >= 0 ; i--) {
			Console.Write (frase[i]);
		}

		Console.Read();
	}
}
